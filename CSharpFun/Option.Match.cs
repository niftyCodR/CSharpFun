using System;

namespace CSharpFun
{
	public static partial class Option
    {
		public static TResult Match<T1, T2, TResult>(this Option<(T1, T2)> option, Func<T1, T2, TResult> onSome, Func<TResult> onNone)
		{
			return option.Match(tuple => onSome(tuple.Item1, tuple.Item2), onNone);
		}

		public static TResult Match<T1, T2, T3, TResult>(this Option<(T1, T2, T3)> option, Func<T1, T2, T3, TResult> onSome, Func<TResult> onNone)
		{
			return option.Match(tuple => onSome(tuple.Item1, tuple.Item2, tuple.Item3), onNone);
		}

		public static TResult Match<T1, T2, T3, T4, TResult>(this Option<(T1, T2, T3, T4)> option, Func<T1, T2, T3, T4, TResult> onSome, Func<TResult> onNone)
		{
			return option.Match(tuple => onSome(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4), onNone);
		}

		public static TResult Match<T1, T2, T3, T4, T5, TResult>(this Option<(T1, T2, T3, T4, T5)> option, Func<T1, T2, T3, T4, T5, TResult> onSome, Func<TResult> onNone)
		{
			return option.Match(tuple => onSome(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5), onNone);
		}

		public static TResult Match<T1, T2, T3, T4, T5, T6, TResult>(this Option<(T1, T2, T3, T4, T5, T6)> option, Func<T1, T2, T3, T4, T5, T6, TResult> onSome, Func<TResult> onNone)
		{
			return option.Match(tuple => onSome(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5, tuple.Item6), onNone);
		}

		public static TResult Match<T1, T2, T3, T4, T5, T6, T7, TResult>(this Option<(T1, T2, T3, T4, T5, T6, T7)> option, Func<T1, T2, T3, T4, T5, T6, T7, TResult> onSome, Func<TResult> onNone)
		{
			return option.Match(tuple => onSome(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5, tuple.Item6, tuple.Item7), onNone);
		}

		public static TResult Match<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(this Option<(T1, T2, T3, T4, T5, T6, T7, T8)> option, Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> onSome, Func<TResult> onNone)
		{
			return option.Match(tuple => onSome(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5, tuple.Item6, tuple.Item7, tuple.Item8), onNone);
		}

		public static TResult Match<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(this Option<(T1, T2, T3, T4, T5, T6, T7, T8, T9)> option, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> onSome, Func<TResult> onNone)
		{
			return option.Match(tuple => onSome(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5, tuple.Item6, tuple.Item7, tuple.Item8, tuple.Item9), onNone);
		}

		public static TResult Match<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(this Option<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10)> option, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> onSome, Func<TResult> onNone)
		{
			return option.Match(tuple => onSome(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5, tuple.Item6, tuple.Item7, tuple.Item8, tuple.Item9, tuple.Item10), onNone);
		}

		public static TResult Match<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(this Option<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11)> option, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> onSome, Func<TResult> onNone)
		{
			return option.Match(tuple => onSome(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5, tuple.Item6, tuple.Item7, tuple.Item8, tuple.Item9, tuple.Item10, tuple.Item11), onNone);
		}

		public static TResult Match<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(this Option<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12)> option, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> onSome, Func<TResult> onNone)
		{
			return option.Match(tuple => onSome(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5, tuple.Item6, tuple.Item7, tuple.Item8, tuple.Item9, tuple.Item10, tuple.Item11, tuple.Item12), onNone);
		}

		public static TResult Match<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(this Option<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13)> option, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> onSome, Func<TResult> onNone)
		{
			return option.Match(tuple => onSome(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5, tuple.Item6, tuple.Item7, tuple.Item8, tuple.Item9, tuple.Item10, tuple.Item11, tuple.Item12, tuple.Item13), onNone);
		}

		public static TResult Match<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this Option<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14)> option, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> onSome, Func<TResult> onNone)
		{
			return option.Match(tuple => onSome(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5, tuple.Item6, tuple.Item7, tuple.Item8, tuple.Item9, tuple.Item10, tuple.Item11, tuple.Item12, tuple.Item13, tuple.Item14), onNone);
		}

		public static TResult Match<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this Option<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15)> option, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> onSome, Func<TResult> onNone)
		{
			return option.Match(tuple => onSome(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5, tuple.Item6, tuple.Item7, tuple.Item8, tuple.Item9, tuple.Item10, tuple.Item11, tuple.Item12, tuple.Item13, tuple.Item14, tuple.Item15), onNone);
		}

		public static TResult Match<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this Option<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16)> option, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> onSome, Func<TResult> onNone)
		{
			return option.Match(tuple => onSome(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5, tuple.Item6, tuple.Item7, tuple.Item8, tuple.Item9, tuple.Item10, tuple.Item11, tuple.Item12, tuple.Item13, tuple.Item14, tuple.Item15, tuple.Item16), onNone);
		}
    }
}