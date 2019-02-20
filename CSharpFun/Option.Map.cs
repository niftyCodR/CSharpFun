using System;

namespace CSharpFun
{
	public static partial class Option
    {
		public static Option<TResult> Map<T, TResult>(this Option<T> option, Func<T, TResult> selector)
        {
            if (selector == null) throw new ArgumentNullException(nameof(selector));

            return option.Match(value => Some(selector(value)), () => None);
        }

		public static Option<TResult> Map<T1, T2, TResult>(this Option<(T1, T2)> option, Func<T1, T2, TResult> selector)
		{
			if (selector == null) throw new ArgumentNullException(nameof(selector));

			return option.Match(tuple => Option<TResult>.Some(selector(tuple.Item1, tuple.Item2)), () => Option<TResult>.None);
		}

		public static Option<TResult> Map<T1, T2, T3, TResult>(this Option<(T1, T2, T3)> option, Func<T1, T2, T3, TResult> selector)
		{
			if (selector == null) throw new ArgumentNullException(nameof(selector));

			return option.Match(tuple => Option<TResult>.Some(selector(tuple.Item1, tuple.Item2, tuple.Item3)), () => Option<TResult>.None);
		}

		public static Option<TResult> Map<T1, T2, T3, T4, TResult>(this Option<(T1, T2, T3, T4)> option, Func<T1, T2, T3, T4, TResult> selector)
		{
			if (selector == null) throw new ArgumentNullException(nameof(selector));

			return option.Match(tuple => Option<TResult>.Some(selector(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4)), () => Option<TResult>.None);
		}

		public static Option<TResult> Map<T1, T2, T3, T4, T5, TResult>(this Option<(T1, T2, T3, T4, T5)> option, Func<T1, T2, T3, T4, T5, TResult> selector)
		{
			if (selector == null) throw new ArgumentNullException(nameof(selector));

			return option.Match(tuple => Option<TResult>.Some(selector(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5)), () => Option<TResult>.None);
		}

		public static Option<TResult> Map<T1, T2, T3, T4, T5, T6, TResult>(this Option<(T1, T2, T3, T4, T5, T6)> option, Func<T1, T2, T3, T4, T5, T6, TResult> selector)
		{
			if (selector == null) throw new ArgumentNullException(nameof(selector));

			return option.Match(tuple => Option<TResult>.Some(selector(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5, tuple.Item6)), () => Option<TResult>.None);
		}

		public static Option<TResult> Map<T1, T2, T3, T4, T5, T6, T7, TResult>(this Option<(T1, T2, T3, T4, T5, T6, T7)> option, Func<T1, T2, T3, T4, T5, T6, T7, TResult> selector)
		{
			if (selector == null) throw new ArgumentNullException(nameof(selector));

			return option.Match(tuple => Option<TResult>.Some(selector(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5, tuple.Item6, tuple.Item7)), () => Option<TResult>.None);
		}

		public static Option<TResult> Map<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(this Option<(T1, T2, T3, T4, T5, T6, T7, T8)> option, Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> selector)
		{
			if (selector == null) throw new ArgumentNullException(nameof(selector));

			return option.Match(tuple => Option<TResult>.Some(selector(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5, tuple.Item6, tuple.Item7, tuple.Item8)), () => Option<TResult>.None);
		}

		public static Option<TResult> Map<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(this Option<(T1, T2, T3, T4, T5, T6, T7, T8, T9)> option, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> selector)
		{
			if (selector == null) throw new ArgumentNullException(nameof(selector));

			return option.Match(tuple => Option<TResult>.Some(selector(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5, tuple.Item6, tuple.Item7, tuple.Item8, tuple.Item9)), () => Option<TResult>.None);
		}

		public static Option<TResult> Map<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(this Option<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10)> option, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> selector)
		{
			if (selector == null) throw new ArgumentNullException(nameof(selector));

			return option.Match(tuple => Option<TResult>.Some(selector(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5, tuple.Item6, tuple.Item7, tuple.Item8, tuple.Item9, tuple.Item10)), () => Option<TResult>.None);
		}

		public static Option<TResult> Map<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(this Option<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11)> option, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> selector)
		{
			if (selector == null) throw new ArgumentNullException(nameof(selector));

			return option.Match(tuple => Option<TResult>.Some(selector(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5, tuple.Item6, tuple.Item7, tuple.Item8, tuple.Item9, tuple.Item10, tuple.Item11)), () => Option<TResult>.None);
		}

		public static Option<TResult> Map<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(this Option<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12)> option, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> selector)
		{
			if (selector == null) throw new ArgumentNullException(nameof(selector));

			return option.Match(tuple => Option<TResult>.Some(selector(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5, tuple.Item6, tuple.Item7, tuple.Item8, tuple.Item9, tuple.Item10, tuple.Item11, tuple.Item12)), () => Option<TResult>.None);
		}

		public static Option<TResult> Map<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(this Option<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13)> option, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> selector)
		{
			if (selector == null) throw new ArgumentNullException(nameof(selector));

			return option.Match(tuple => Option<TResult>.Some(selector(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5, tuple.Item6, tuple.Item7, tuple.Item8, tuple.Item9, tuple.Item10, tuple.Item11, tuple.Item12, tuple.Item13)), () => Option<TResult>.None);
		}

		public static Option<TResult> Map<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this Option<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14)> option, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> selector)
		{
			if (selector == null) throw new ArgumentNullException(nameof(selector));

			return option.Match(tuple => Option<TResult>.Some(selector(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5, tuple.Item6, tuple.Item7, tuple.Item8, tuple.Item9, tuple.Item10, tuple.Item11, tuple.Item12, tuple.Item13, tuple.Item14)), () => Option<TResult>.None);
		}

		public static Option<TResult> Map<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this Option<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15)> option, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> selector)
		{
			if (selector == null) throw new ArgumentNullException(nameof(selector));

			return option.Match(tuple => Option<TResult>.Some(selector(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5, tuple.Item6, tuple.Item7, tuple.Item8, tuple.Item9, tuple.Item10, tuple.Item11, tuple.Item12, tuple.Item13, tuple.Item14, tuple.Item15)), () => Option<TResult>.None);
		}

		public static Option<TResult> Map<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this Option<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16)> option, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> selector)
		{
			if (selector == null) throw new ArgumentNullException(nameof(selector));

			return option.Match(tuple => Option<TResult>.Some(selector(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5, tuple.Item6, tuple.Item7, tuple.Item8, tuple.Item9, tuple.Item10, tuple.Item11, tuple.Item12, tuple.Item13, tuple.Item14, tuple.Item15, tuple.Item16)), () => Option<TResult>.None);
		}
	}
}