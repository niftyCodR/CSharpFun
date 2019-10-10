using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace CSharpFun
{
    public abstract class ValueObject
    {
        protected virtual IEnumerable<object> GetEqualityMembers()
        {
            return PublicMemberUtil.GetPublicMembersFunc(GetType()).Invoke(this);
        }

        protected static bool SaveEquals<T>(T a, T b) => a?.Equals(b) ?? b == null;

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType() || !(obj is ValueObject other))
                return false;

            var members = GetEqualityMembers();
            var otherMembers =  other.GetEqualityMembers();

            return members.SequenceEqual(otherMembers);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return GetEqualityMembers().Aggregate(0, (acc, val) => acc * 397 + val?.GetHashCode() ?? 0);
            }
        }

        public override string ToString()
        {
            return string.Join(";###;", GetEqualityMembers().Where(value => value != null));
        }

        private static class PublicMemberUtil
        {
            private static readonly ConcurrentDictionary<Type, Func<object, IEnumerable<object>>> Cache = new ConcurrentDictionary<Type, Func<object, IEnumerable<object>>>();

            public static Func<object, IEnumerable<object>> GetPublicMembersFunc(Type type)
            {
                return Cache.GetOrAdd(type, GetEqualityMembersFunc);
            }

            private static Func<object, IEnumerable<object>> GetEqualityMembersFunc(Type type)
            {
                var properties = type.GetProperties()
                    .Where(p => p.CanRead && p.DeclaringType == typeof(ValueObject))
                    .Cast<MemberInfo>();

                var fields = type.GetFields()
                    .Where(f => f.IsInitOnly && !f.IsStatic)
                    .Cast<MemberInfo>();

                var memberAccessors = properties.Union(fields)
                    .Select(GetMemberAccessor)
                    .ToList();

                return valueObject => memberAccessors
                    .Select(getter => getter(valueObject))
                    .ToList();

                Func<object, object> GetMemberAccessor(MemberInfo member)
                {
                    var param = Expression.Parameter(typeof(object), "source");
                    // ReSharper disable once AssignNullToNotNullAttribute
                    var source = Expression.Convert(param, member.DeclaringType);
                    var get = Expression.MakeMemberAccess(source, member);
                    var convert = Expression.Convert(get, typeof(object));
                    var lambda = Expression.Lambda<Func<object, object>>(convert, param);

                    return lambda.Compile();
                }
            }
        }
    }

    public abstract class SingleValueObject<T> : ValueObject
    {
        protected SingleValueObject(T value)
        {
            Value = value;
        }

        public T Value { get; }

        protected override IEnumerable<object> GetEqualityMembers()
        {
            yield return Value;
        }

        public override string ToString()
        {
            return Value?.ToString() ?? "";
        }

        public static implicit operator T(SingleValueObject<T> valueObject) => valueObject.Value;
    }
}