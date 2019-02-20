using System;
using System.Collections.Generic;

namespace CSharpFun
{
	public struct ChoiceCase1<T>
    {
        public T Value { get; }

        public ChoiceCase1(T value)
        {
            Value = value;
        }
    }

	public struct ChoiceCase2<T>
    {
        public T Value { get; }

        public ChoiceCase2(T value)
        {
            Value = value;
        }
    }

	public struct ChoiceCase3<T>
    {
        public T Value { get; }

        public ChoiceCase3(T value)
        {
            Value = value;
        }
    }

	public struct ChoiceCase4<T>
    {
        public T Value { get; }

        public ChoiceCase4(T value)
        {
            Value = value;
        }
    }

	public struct ChoiceCase5<T>
    {
        public T Value { get; }

        public ChoiceCase5(T value)
        {
            Value = value;
        }
    }

    public static class Choice
    {
		public static ChoiceCase1<T> Case1<T>(T value) => new ChoiceCase1<T>(value);

		public static ChoiceCase2<T> Case2<T>(T value) => new ChoiceCase2<T>(value);

		public static ChoiceCase3<T> Case3<T>(T value) => new ChoiceCase3<T>(value);

		public static ChoiceCase4<T> Case4<T>(T value) => new ChoiceCase4<T>(value);

		public static ChoiceCase5<T> Case5<T>(T value) => new ChoiceCase5<T>(value);
    }

    public enum ChoiceCase
    {
		Undefined,
		Case1,
		Case2,
		Case3,
		Case4,
		Case5,
    }

	public struct Choice<TCase1, TCase2> : IEquatable<Choice<TCase1, TCase2>>
	{
		private static readonly IEqualityComparer<Choice<TCase1, TCase2>> EqualityComparer = new MemberEqualityComparer<Choice<TCase1, TCase2>>(GetEqualityMembers);

		private readonly TCase1 _case1;
		private readonly TCase2 _case2;

		private Choice(ChoiceCase @case, TCase1 case1, TCase2 case2)
        {
            Case = @case;
			_case1 = case1;
			_case2 = case2;
        }

		public static Choice<TCase1, TCase2> Case1(TCase1 value) => new Choice<TCase1, TCase2>(ChoiceCase.Case1, value, default);

		public static Choice<TCase1, TCase2> Case2(TCase2 value) => new Choice<TCase1, TCase2>(ChoiceCase.Case2, default, value);

		public ChoiceCase Case { get; }

		public bool IsCase1 => Case == ChoiceCase.Case1;
		public bool IsCase2 => Case == ChoiceCase.Case2;
		
        public TResult Match<TResult>(Func<TCase1, TResult> case1, Func<TCase2, TResult> case2)
        {
            switch (Case)
            {
                case ChoiceCase.Undefined:
				case ChoiceCase.Case1:
                    return case1(_case1);
				case ChoiceCase.Case2:
                    return case2(_case2);
                default:
                    throw new InvalidOperationException("Bug: Undefined choice case.");

            }
        }

		private static IEnumerable<object> GetEqualityMembers(Choice<TCase1, TCase2> x)
        {
            yield return x.Case;
            yield return x.Match<object>(value => value, value => value);
        }

		public bool Equals(Choice<TCase1, TCase2> other) => EqualityComparer.Equals(this, other);

        public override bool Equals(object obj) => obj is Choice<TCase1, TCase2> other && Equals(other);

        public override int GetHashCode() => EqualityComparer.GetHashCode(this);

        public static bool operator ==(Choice<TCase1, TCase2> a, Choice<TCase1, TCase2> b) => a.Equals(b);

        public static bool operator !=(Choice<TCase1, TCase2> a, Choice<TCase1, TCase2> b) => !(a == b);

		public static bool operator ==(Choice<TCase1, TCase2> a, ChoiceCase1<TCase1> b) => a.IsCase1;

        public static bool operator !=(Choice<TCase1, TCase2> a, ChoiceCase1<TCase1> b) => !(a == b);

		public static bool operator ==(Choice<TCase1, TCase2> a, ChoiceCase2<TCase2> b) => a.IsCase2;

        public static bool operator !=(Choice<TCase1, TCase2> a, ChoiceCase2<TCase2> b) => !(a == b);

		public static implicit operator Choice<TCase1, TCase2>(ChoiceCase1<TCase1> @case) => Case1(@case.Value);

		public static implicit operator Choice<TCase1, TCase2>(ChoiceCase2<TCase2> @case) => Case2(@case.Value);
	}

	public struct Choice<TCase1, TCase2, TCase3> : IEquatable<Choice<TCase1, TCase2, TCase3>>
	{
		private static readonly IEqualityComparer<Choice<TCase1, TCase2, TCase3>> EqualityComparer = new MemberEqualityComparer<Choice<TCase1, TCase2, TCase3>>(GetEqualityMembers);

		private readonly TCase1 _case1;
		private readonly TCase2 _case2;
		private readonly TCase3 _case3;

		private Choice(ChoiceCase @case, TCase1 case1, TCase2 case2, TCase3 case3)
        {
            Case = @case;
			_case1 = case1;
			_case2 = case2;
			_case3 = case3;
        }

		public static Choice<TCase1, TCase2, TCase3> Case1(TCase1 value) => new Choice<TCase1, TCase2, TCase3>(ChoiceCase.Case1, value, default, default);

		public static Choice<TCase1, TCase2, TCase3> Case2(TCase2 value) => new Choice<TCase1, TCase2, TCase3>(ChoiceCase.Case2, default, value, default);

		public static Choice<TCase1, TCase2, TCase3> Case3(TCase3 value) => new Choice<TCase1, TCase2, TCase3>(ChoiceCase.Case3, default, default, value);

		public ChoiceCase Case { get; }

		public bool IsCase1 => Case == ChoiceCase.Case1;
		public bool IsCase2 => Case == ChoiceCase.Case2;
		public bool IsCase3 => Case == ChoiceCase.Case3;
		
        public TResult Match<TResult>(Func<TCase1, TResult> case1, Func<TCase2, TResult> case2, Func<TCase3, TResult> case3)
        {
            switch (Case)
            {
                case ChoiceCase.Undefined:
				case ChoiceCase.Case1:
                    return case1(_case1);
				case ChoiceCase.Case2:
                    return case2(_case2);
				case ChoiceCase.Case3:
                    return case3(_case3);
                default:
                    throw new InvalidOperationException("Bug: Undefined choice case.");

            }
        }

		private static IEnumerable<object> GetEqualityMembers(Choice<TCase1, TCase2, TCase3> x)
        {
            yield return x.Case;
            yield return x.Match<object>(value => value, value => value, value => value);
        }

		public bool Equals(Choice<TCase1, TCase2, TCase3> other) => EqualityComparer.Equals(this, other);

        public override bool Equals(object obj) => obj is Choice<TCase1, TCase2, TCase3> other && Equals(other);

        public override int GetHashCode() => EqualityComparer.GetHashCode(this);

        public static bool operator ==(Choice<TCase1, TCase2, TCase3> a, Choice<TCase1, TCase2, TCase3> b) => a.Equals(b);

        public static bool operator !=(Choice<TCase1, TCase2, TCase3> a, Choice<TCase1, TCase2, TCase3> b) => !(a == b);

		public static bool operator ==(Choice<TCase1, TCase2, TCase3> a, ChoiceCase1<TCase1> b) => a.IsCase1;

        public static bool operator !=(Choice<TCase1, TCase2, TCase3> a, ChoiceCase1<TCase1> b) => !(a == b);

		public static bool operator ==(Choice<TCase1, TCase2, TCase3> a, ChoiceCase2<TCase2> b) => a.IsCase2;

        public static bool operator !=(Choice<TCase1, TCase2, TCase3> a, ChoiceCase2<TCase2> b) => !(a == b);

		public static bool operator ==(Choice<TCase1, TCase2, TCase3> a, ChoiceCase3<TCase3> b) => a.IsCase3;

        public static bool operator !=(Choice<TCase1, TCase2, TCase3> a, ChoiceCase3<TCase3> b) => !(a == b);

		public static implicit operator Choice<TCase1, TCase2, TCase3>(ChoiceCase1<TCase1> @case) => Case1(@case.Value);

		public static implicit operator Choice<TCase1, TCase2, TCase3>(ChoiceCase2<TCase2> @case) => Case2(@case.Value);

		public static implicit operator Choice<TCase1, TCase2, TCase3>(ChoiceCase3<TCase3> @case) => Case3(@case.Value);

		public static implicit operator Choice<TCase1, TCase2, TCase3>(Choice<TCase1, TCase2> choice) => choice.Match(Case1, Case2);
	}

	public struct Choice<TCase1, TCase2, TCase3, TCase4> : IEquatable<Choice<TCase1, TCase2, TCase3, TCase4>>
	{
		private static readonly IEqualityComparer<Choice<TCase1, TCase2, TCase3, TCase4>> EqualityComparer = new MemberEqualityComparer<Choice<TCase1, TCase2, TCase3, TCase4>>(GetEqualityMembers);

		private readonly TCase1 _case1;
		private readonly TCase2 _case2;
		private readonly TCase3 _case3;
		private readonly TCase4 _case4;

		private Choice(ChoiceCase @case, TCase1 case1, TCase2 case2, TCase3 case3, TCase4 case4)
        {
            Case = @case;
			_case1 = case1;
			_case2 = case2;
			_case3 = case3;
			_case4 = case4;
        }

		public static Choice<TCase1, TCase2, TCase3, TCase4> Case1(TCase1 value) => new Choice<TCase1, TCase2, TCase3, TCase4>(ChoiceCase.Case1, value, default, default, default);

		public static Choice<TCase1, TCase2, TCase3, TCase4> Case2(TCase2 value) => new Choice<TCase1, TCase2, TCase3, TCase4>(ChoiceCase.Case2, default, value, default, default);

		public static Choice<TCase1, TCase2, TCase3, TCase4> Case3(TCase3 value) => new Choice<TCase1, TCase2, TCase3, TCase4>(ChoiceCase.Case3, default, default, value, default);

		public static Choice<TCase1, TCase2, TCase3, TCase4> Case4(TCase4 value) => new Choice<TCase1, TCase2, TCase3, TCase4>(ChoiceCase.Case4, default, default, default, value);

		public ChoiceCase Case { get; }

		public bool IsCase1 => Case == ChoiceCase.Case1;
		public bool IsCase2 => Case == ChoiceCase.Case2;
		public bool IsCase3 => Case == ChoiceCase.Case3;
		public bool IsCase4 => Case == ChoiceCase.Case4;
		
        public TResult Match<TResult>(Func<TCase1, TResult> case1, Func<TCase2, TResult> case2, Func<TCase3, TResult> case3, Func<TCase4, TResult> case4)
        {
            switch (Case)
            {
                case ChoiceCase.Undefined:
				case ChoiceCase.Case1:
                    return case1(_case1);
				case ChoiceCase.Case2:
                    return case2(_case2);
				case ChoiceCase.Case3:
                    return case3(_case3);
				case ChoiceCase.Case4:
                    return case4(_case4);
                default:
                    throw new InvalidOperationException("Bug: Undefined choice case.");

            }
        }

		private static IEnumerable<object> GetEqualityMembers(Choice<TCase1, TCase2, TCase3, TCase4> x)
        {
            yield return x.Case;
            yield return x.Match<object>(value => value, value => value, value => value, value => value);
        }

		public bool Equals(Choice<TCase1, TCase2, TCase3, TCase4> other) => EqualityComparer.Equals(this, other);

        public override bool Equals(object obj) => obj is Choice<TCase1, TCase2, TCase3, TCase4> other && Equals(other);

        public override int GetHashCode() => EqualityComparer.GetHashCode(this);

        public static bool operator ==(Choice<TCase1, TCase2, TCase3, TCase4> a, Choice<TCase1, TCase2, TCase3, TCase4> b) => a.Equals(b);

        public static bool operator !=(Choice<TCase1, TCase2, TCase3, TCase4> a, Choice<TCase1, TCase2, TCase3, TCase4> b) => !(a == b);

		public static bool operator ==(Choice<TCase1, TCase2, TCase3, TCase4> a, ChoiceCase1<TCase1> b) => a.IsCase1;

        public static bool operator !=(Choice<TCase1, TCase2, TCase3, TCase4> a, ChoiceCase1<TCase1> b) => !(a == b);

		public static bool operator ==(Choice<TCase1, TCase2, TCase3, TCase4> a, ChoiceCase2<TCase2> b) => a.IsCase2;

        public static bool operator !=(Choice<TCase1, TCase2, TCase3, TCase4> a, ChoiceCase2<TCase2> b) => !(a == b);

		public static bool operator ==(Choice<TCase1, TCase2, TCase3, TCase4> a, ChoiceCase3<TCase3> b) => a.IsCase3;

        public static bool operator !=(Choice<TCase1, TCase2, TCase3, TCase4> a, ChoiceCase3<TCase3> b) => !(a == b);

		public static bool operator ==(Choice<TCase1, TCase2, TCase3, TCase4> a, ChoiceCase4<TCase4> b) => a.IsCase4;

        public static bool operator !=(Choice<TCase1, TCase2, TCase3, TCase4> a, ChoiceCase4<TCase4> b) => !(a == b);

		public static implicit operator Choice<TCase1, TCase2, TCase3, TCase4>(ChoiceCase1<TCase1> @case) => Case1(@case.Value);

		public static implicit operator Choice<TCase1, TCase2, TCase3, TCase4>(ChoiceCase2<TCase2> @case) => Case2(@case.Value);

		public static implicit operator Choice<TCase1, TCase2, TCase3, TCase4>(ChoiceCase3<TCase3> @case) => Case3(@case.Value);

		public static implicit operator Choice<TCase1, TCase2, TCase3, TCase4>(ChoiceCase4<TCase4> @case) => Case4(@case.Value);

		public static implicit operator Choice<TCase1, TCase2, TCase3, TCase4>(Choice<TCase1, TCase2> choice) => choice.Match(Case1, Case2);

		public static implicit operator Choice<TCase1, TCase2, TCase3, TCase4>(Choice<TCase1, TCase2, TCase3> choice) => choice.Match(Case1, Case2, Case3);
	}

	public struct Choice<TCase1, TCase2, TCase3, TCase4, TCase5> : IEquatable<Choice<TCase1, TCase2, TCase3, TCase4, TCase5>>
	{
		private static readonly IEqualityComparer<Choice<TCase1, TCase2, TCase3, TCase4, TCase5>> EqualityComparer = new MemberEqualityComparer<Choice<TCase1, TCase2, TCase3, TCase4, TCase5>>(GetEqualityMembers);

		private readonly TCase1 _case1;
		private readonly TCase2 _case2;
		private readonly TCase3 _case3;
		private readonly TCase4 _case4;
		private readonly TCase5 _case5;

		private Choice(ChoiceCase @case, TCase1 case1, TCase2 case2, TCase3 case3, TCase4 case4, TCase5 case5)
        {
            Case = @case;
			_case1 = case1;
			_case2 = case2;
			_case3 = case3;
			_case4 = case4;
			_case5 = case5;
        }

		public static Choice<TCase1, TCase2, TCase3, TCase4, TCase5> Case1(TCase1 value) => new Choice<TCase1, TCase2, TCase3, TCase4, TCase5>(ChoiceCase.Case1, value, default, default, default, default);

		public static Choice<TCase1, TCase2, TCase3, TCase4, TCase5> Case2(TCase2 value) => new Choice<TCase1, TCase2, TCase3, TCase4, TCase5>(ChoiceCase.Case2, default, value, default, default, default);

		public static Choice<TCase1, TCase2, TCase3, TCase4, TCase5> Case3(TCase3 value) => new Choice<TCase1, TCase2, TCase3, TCase4, TCase5>(ChoiceCase.Case3, default, default, value, default, default);

		public static Choice<TCase1, TCase2, TCase3, TCase4, TCase5> Case4(TCase4 value) => new Choice<TCase1, TCase2, TCase3, TCase4, TCase5>(ChoiceCase.Case4, default, default, default, value, default);

		public static Choice<TCase1, TCase2, TCase3, TCase4, TCase5> Case5(TCase5 value) => new Choice<TCase1, TCase2, TCase3, TCase4, TCase5>(ChoiceCase.Case5, default, default, default, default, value);

		public ChoiceCase Case { get; }

		public bool IsCase1 => Case == ChoiceCase.Case1;
		public bool IsCase2 => Case == ChoiceCase.Case2;
		public bool IsCase3 => Case == ChoiceCase.Case3;
		public bool IsCase4 => Case == ChoiceCase.Case4;
		public bool IsCase5 => Case == ChoiceCase.Case5;
		
        public TResult Match<TResult>(Func<TCase1, TResult> case1, Func<TCase2, TResult> case2, Func<TCase3, TResult> case3, Func<TCase4, TResult> case4, Func<TCase5, TResult> case5)
        {
            switch (Case)
            {
                case ChoiceCase.Undefined:
				case ChoiceCase.Case1:
                    return case1(_case1);
				case ChoiceCase.Case2:
                    return case2(_case2);
				case ChoiceCase.Case3:
                    return case3(_case3);
				case ChoiceCase.Case4:
                    return case4(_case4);
				case ChoiceCase.Case5:
                    return case5(_case5);
                default:
                    throw new InvalidOperationException("Bug: Undefined choice case.");

            }
        }

		private static IEnumerable<object> GetEqualityMembers(Choice<TCase1, TCase2, TCase3, TCase4, TCase5> x)
        {
            yield return x.Case;
            yield return x.Match<object>(value => value, value => value, value => value, value => value, value => value);
        }

		public bool Equals(Choice<TCase1, TCase2, TCase3, TCase4, TCase5> other) => EqualityComparer.Equals(this, other);

        public override bool Equals(object obj) => obj is Choice<TCase1, TCase2, TCase3, TCase4, TCase5> other && Equals(other);

        public override int GetHashCode() => EqualityComparer.GetHashCode(this);

        public static bool operator ==(Choice<TCase1, TCase2, TCase3, TCase4, TCase5> a, Choice<TCase1, TCase2, TCase3, TCase4, TCase5> b) => a.Equals(b);

        public static bool operator !=(Choice<TCase1, TCase2, TCase3, TCase4, TCase5> a, Choice<TCase1, TCase2, TCase3, TCase4, TCase5> b) => !(a == b);

		public static bool operator ==(Choice<TCase1, TCase2, TCase3, TCase4, TCase5> a, ChoiceCase1<TCase1> b) => a.IsCase1;

        public static bool operator !=(Choice<TCase1, TCase2, TCase3, TCase4, TCase5> a, ChoiceCase1<TCase1> b) => !(a == b);

		public static bool operator ==(Choice<TCase1, TCase2, TCase3, TCase4, TCase5> a, ChoiceCase2<TCase2> b) => a.IsCase2;

        public static bool operator !=(Choice<TCase1, TCase2, TCase3, TCase4, TCase5> a, ChoiceCase2<TCase2> b) => !(a == b);

		public static bool operator ==(Choice<TCase1, TCase2, TCase3, TCase4, TCase5> a, ChoiceCase3<TCase3> b) => a.IsCase3;

        public static bool operator !=(Choice<TCase1, TCase2, TCase3, TCase4, TCase5> a, ChoiceCase3<TCase3> b) => !(a == b);

		public static bool operator ==(Choice<TCase1, TCase2, TCase3, TCase4, TCase5> a, ChoiceCase4<TCase4> b) => a.IsCase4;

        public static bool operator !=(Choice<TCase1, TCase2, TCase3, TCase4, TCase5> a, ChoiceCase4<TCase4> b) => !(a == b);

		public static bool operator ==(Choice<TCase1, TCase2, TCase3, TCase4, TCase5> a, ChoiceCase5<TCase5> b) => a.IsCase5;

        public static bool operator !=(Choice<TCase1, TCase2, TCase3, TCase4, TCase5> a, ChoiceCase5<TCase5> b) => !(a == b);

		public static implicit operator Choice<TCase1, TCase2, TCase3, TCase4, TCase5>(ChoiceCase1<TCase1> @case) => Case1(@case.Value);

		public static implicit operator Choice<TCase1, TCase2, TCase3, TCase4, TCase5>(ChoiceCase2<TCase2> @case) => Case2(@case.Value);

		public static implicit operator Choice<TCase1, TCase2, TCase3, TCase4, TCase5>(ChoiceCase3<TCase3> @case) => Case3(@case.Value);

		public static implicit operator Choice<TCase1, TCase2, TCase3, TCase4, TCase5>(ChoiceCase4<TCase4> @case) => Case4(@case.Value);

		public static implicit operator Choice<TCase1, TCase2, TCase3, TCase4, TCase5>(ChoiceCase5<TCase5> @case) => Case5(@case.Value);

		public static implicit operator Choice<TCase1, TCase2, TCase3, TCase4, TCase5>(Choice<TCase1, TCase2> choice) => choice.Match(Case1, Case2);

		public static implicit operator Choice<TCase1, TCase2, TCase3, TCase4, TCase5>(Choice<TCase1, TCase2, TCase3> choice) => choice.Match(Case1, Case2, Case3);

		public static implicit operator Choice<TCase1, TCase2, TCase3, TCase4, TCase5>(Choice<TCase1, TCase2, TCase3, TCase4> choice) => choice.Match(Case1, Case2, Case3, Case4);
	}
}