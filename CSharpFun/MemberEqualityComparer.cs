using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpFun
{
    public sealed class MemberEqualityComparer<T> : IEqualityComparer<T>
    {
        private readonly Func<T, IEnumerable<object>> _getEqualityMembers;

        public MemberEqualityComparer(Func<T, IEnumerable<object>> getEqualityMembers)
        {
            _getEqualityMembers = getEqualityMembers ?? throw new ArgumentNullException(nameof(getEqualityMembers));
        }

        public bool Equals(T a, T b)
        {
            if(a == null || b == null || a.GetType() != b.GetType())
                return false;

            var members = _getEqualityMembers(a);
            var otherMembers = _getEqualityMembers(b);

            return members.SequenceEqual(otherMembers);
        }

        public int GetHashCode(T a)
        {
            unchecked
            {
                return _getEqualityMembers(a).Aggregate(0, (acc, val) => acc * 397 + val?.GetHashCode() ?? 0);
            }
        }

        public string ToString(T a)
        {
            return a == null
                ? ""
                : string.Join(";###;", _getEqualityMembers(a).Where(value => value != null));
        }
    }
}