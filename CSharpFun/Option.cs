using System;

namespace CSharpFun
{
    public struct Option<T> : IEquatable<Option<T>>, IEquatable<T>
    {
        private readonly T _value;

        private Option(bool hasValue, T value)
        {
            IsSome = hasValue;
            _value = value;
        }

        /// <summary>
        /// Creates an option which represents a value.
        /// </summary>
        /// <para>
        /// !!!Attention!!! Using this method feels clumsy. For a more
        /// elegant solution please consider using <see cref="Option.Some{T}"/>.
        /// </para>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="value"/> is null.
        /// </exception>
        public static Option<T> Some(T value)
        {
            if(ReferenceEquals(null, value))
                throw new ArgumentNullException(nameof(value));

            return new Option<T>(true, value);
        }

        /// <summary>
        /// Provides an option which represents the absence of a value.
        /// <para>
        /// !!!Attention!!! Using this method feels clumsy. For a more
        /// elegant solution please consider using <see cref="Option.None"/>.
        /// </para>
        /// </summary>
        public static Option<T> None { get; } = new Option<T>(false, default);

        public bool IsSome { get; }

        public bool IsNone => !IsSome;

        public TResult Match<TResult>(Func<T, TResult> onSome, Func<TResult> onNone)
        {
            if (onSome == null) throw new ArgumentNullException(nameof(onSome));
            if (onNone == null) throw new ArgumentNullException(nameof(onNone));

            return IsSome ? onSome(_value) : onNone();
        }

        #region Equality Implementation

        public bool Equals(Option<T> other)
        {
            if (IsNone)
                return other.IsNone;

            return other.IsSome && Equals(_value, other._value);
        }

        public bool Equals(T other)
        {
            return Match(val => Equals(val, other), () => false);
        }

        public override bool Equals(object obj) => obj is Option<T> other && Equals(other);

        public override int GetHashCode() => IsNone ? 0 : 397 ^ _value.GetHashCode();

        public static bool operator ==(Option<T> a, Option<T> b) => a.Equals(b);

        public static bool operator !=(Option<T> a, Option<T> b) => !(a == b);

        public static bool operator ==(Option<T> a, NoneOption b) => a.IsNone;

        public static bool operator !=(Option<T> a, NoneOption b) => !(a == b);

        public static bool operator ==(NoneOption a, Option<T> b) => b.IsNone;

        public static bool operator !=(NoneOption a, Option<T> b) => !(a == b);

        public static bool operator ==(Option<T> a, T b) => a.Equals(b);

        public static bool operator !=(Option<T> a, T b) => !(a == b);

        public static bool operator ==(T a, Option<T> b) => b == a;

        public static bool operator !=(T a, Option<T> b) => !(a == b);

        #endregion

        #region Casting Operators

        public static implicit operator Option<T>(NoneOption none) => None;

        public static implicit operator Option<Unit>(Option<T> option) => option.Match(_ => Option<Unit>.Some(Unit.Value), () => Option<Unit>.None);

        #endregion
    }

    public static partial class Option
    {
        /// <summary>
        /// Creates an option which represents a value.
        /// </summary>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="value"/> is null.
        /// </exception>
        public static Option<T> Some<T>(T value) => Option<T>.Some(value);

        public static Option<Unit> Some() => Some(Unit.Value);

        /// <summary>
        /// Creates an option which represents a value.
        /// <para>Does NOT throw an exception. If <paramref name="value"/> is null, returns <see cref="Option{T}.None"/>.</para>
        /// </summary>
        public static Option<T> SomeOrNoneWhenNull<T>(T value) => ReferenceEquals(null, value) ? Option<T>.None : Option<T>.Some(value);

        public static NoneOption None { get; } = default;

        /// <summary>
        /// Provides a way to create a &quot;typed&quot; option representing a None value.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static Option<T> NoneOf<T>() => Option<T>.None;

        public static Option<T> If<T>(bool condition, T value)
        {
            return value != null && condition ? Some(value) : None;
        }

        public static Option<T> IfNot<T>(bool condition, T value)
        {
            return value != null && !condition ? Some(value) : None;
        }

        public static Option<T> If<T>(Func<T, bool> predicate, T value)
        {
            if (predicate == null) throw new ArgumentNullException(nameof(predicate));

            return value != null && predicate(value) ? Some(value) : None;
        }

        public static Option<T> IfNot<T>(Func<T, bool> predicate, T value)
        {
            if (predicate == null) throw new ArgumentNullException(nameof(predicate));

            return value != null && !predicate(value) ? Some(value) : None;
        }

        /// <summary>
        /// Tries to extract the value from the option, causing an exception for <see cref="Option.None"/> values.
        /// </summary>
        /// <exception cref="ArgumentException">
        /// Thrown when the option <see cref="Option{T}.IsNone"/>.
        /// </exception>
        public static T GetValueOrThrow<T>(this Option<T> option)
        {
            return option.Match(
                val => val,
                () => throw new ArgumentException("Option represents no value (None), cannot extract value.", nameof(option))
            );
        }

        public static bool TryGetValue<T>(this Option<T> option, out T value)
        {
            option.Deconstruct(out var isSome, out value);

            return isSome;
        }

        public static void Deconstruct<T>(this Option<T> option, out bool isSome, out T value)
        {
            isSome = option.IsSome;
            value = option.Match(val => val, () => default);
        }

        public static T GetValueOr<T>(this Option<T> option, T fallback)
        {
            return option.Match(val => val, () => fallback);
        }

        public static Option<T> Filter<T>(this Option<T> option, Func<T, bool> predicate)
        {
            return option.Match(value => predicate(value) ? option : Option<T>.None, () => option);
        }

        public static Option<T> ToOption<T>(this T? nullable) where T : struct
        {
            return nullable.HasValue ? Option<T>.Some(nullable.Value) : Option<T>.None;
        }

        public static T? ToNullable<T>(this Option<T> option) where T : struct
        {
            return option.Match(value => value, () => (T?)null);
        }

        public static Option<T> OnSome<T>(this Option<T> option, Action<T> onSome)
        {
            return option.Match(
                value =>
                {
                    onSome(value);
                    return option;
                },
                () => option
            );
        }

        public static Option<Unit> Do(Action action)
        {
            action();
            return Some(Unit.Value);
        }
    }
}    