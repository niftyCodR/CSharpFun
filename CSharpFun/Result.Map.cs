using System;

namespace CSharpFun
{
    public static partial class Result
    {
		public static Result<TResult, TError> Map<T, TError, TResult>(this Result<T, TError> result, Func<T, TResult> selector)
        {
			if (selector == null) throw new ArgumentNullException(nameof(selector));

            return result.Match(value => Result<TResult, TError>.Success(selector(value)), Result<TResult, TError>.Error);
        }

		public static Result<T, TResultError> MapError<T, TError, TResultError>(this Result<T, TError> result, Func<TError, TResultError> selector)
        {
			if (selector == null) throw new ArgumentNullException(nameof(selector));

            return result.Match(Result<T, TResultError>.Success, error => Result<T, TResultError>.Error(selector(error)));
        }

		public static Result<TResult, TError> Map<T1, T2, TError, TResult>(this Result<(T1, T2), TError> result, Func<T1, T2, TResult> selector)
		{
			if (selector == null) throw new ArgumentNullException(nameof(selector));

			return result.Match(tuple => Result<TResult, TError>.Success(selector(tuple.Item1, tuple.Item2)), Result<TResult, TError>.Error);
		}

		public static Result<TResult, TError> Map<T1, T2, T3, TError, TResult>(this Result<(T1, T2, T3), TError> result, Func<T1, T2, T3, TResult> selector)
		{
			if (selector == null) throw new ArgumentNullException(nameof(selector));

			return result.Match(tuple => Result<TResult, TError>.Success(selector(tuple.Item1, tuple.Item2, tuple.Item3)), Result<TResult, TError>.Error);
		}

		public static Result<TResult, TError> Map<T1, T2, T3, T4, TError, TResult>(this Result<(T1, T2, T3, T4), TError> result, Func<T1, T2, T3, T4, TResult> selector)
		{
			if (selector == null) throw new ArgumentNullException(nameof(selector));

			return result.Match(tuple => Result<TResult, TError>.Success(selector(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4)), Result<TResult, TError>.Error);
		}

		public static Result<TResult, TError> Map<T1, T2, T3, T4, T5, TError, TResult>(this Result<(T1, T2, T3, T4, T5), TError> result, Func<T1, T2, T3, T4, T5, TResult> selector)
		{
			if (selector == null) throw new ArgumentNullException(nameof(selector));

			return result.Match(tuple => Result<TResult, TError>.Success(selector(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5)), Result<TResult, TError>.Error);
		}

		public static Result<TResult, TError> Map<T1, T2, T3, T4, T5, T6, TError, TResult>(this Result<(T1, T2, T3, T4, T5, T6), TError> result, Func<T1, T2, T3, T4, T5, T6, TResult> selector)
		{
			if (selector == null) throw new ArgumentNullException(nameof(selector));

			return result.Match(tuple => Result<TResult, TError>.Success(selector(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5, tuple.Item6)), Result<TResult, TError>.Error);
		}

		public static Result<TResult, TError> Map<T1, T2, T3, T4, T5, T6, T7, TError, TResult>(this Result<(T1, T2, T3, T4, T5, T6, T7), TError> result, Func<T1, T2, T3, T4, T5, T6, T7, TResult> selector)
		{
			if (selector == null) throw new ArgumentNullException(nameof(selector));

			return result.Match(tuple => Result<TResult, TError>.Success(selector(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5, tuple.Item6, tuple.Item7)), Result<TResult, TError>.Error);
		}

		public static Result<TResult, TError> Map<T1, T2, T3, T4, T5, T6, T7, T8, TError, TResult>(this Result<(T1, T2, T3, T4, T5, T6, T7, T8), TError> result, Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> selector)
		{
			if (selector == null) throw new ArgumentNullException(nameof(selector));

			return result.Match(tuple => Result<TResult, TError>.Success(selector(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5, tuple.Item6, tuple.Item7, tuple.Item8)), Result<TResult, TError>.Error);
		}

		public static Result<TResult, TError> Map<T1, T2, T3, T4, T5, T6, T7, T8, T9, TError, TResult>(this Result<(T1, T2, T3, T4, T5, T6, T7, T8, T9), TError> result, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> selector)
		{
			if (selector == null) throw new ArgumentNullException(nameof(selector));

			return result.Match(tuple => Result<TResult, TError>.Success(selector(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5, tuple.Item6, tuple.Item7, tuple.Item8, tuple.Item9)), Result<TResult, TError>.Error);
		}

		public static Result<TResult, TError> Map<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TError, TResult>(this Result<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10), TError> result, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> selector)
		{
			if (selector == null) throw new ArgumentNullException(nameof(selector));

			return result.Match(tuple => Result<TResult, TError>.Success(selector(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5, tuple.Item6, tuple.Item7, tuple.Item8, tuple.Item9, tuple.Item10)), Result<TResult, TError>.Error);
		}

		public static Result<TResult, TError> Map<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TError, TResult>(this Result<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11), TError> result, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> selector)
		{
			if (selector == null) throw new ArgumentNullException(nameof(selector));

			return result.Match(tuple => Result<TResult, TError>.Success(selector(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5, tuple.Item6, tuple.Item7, tuple.Item8, tuple.Item9, tuple.Item10, tuple.Item11)), Result<TResult, TError>.Error);
		}

		public static Result<TResult, TError> Map<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TError, TResult>(this Result<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12), TError> result, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> selector)
		{
			if (selector == null) throw new ArgumentNullException(nameof(selector));

			return result.Match(tuple => Result<TResult, TError>.Success(selector(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5, tuple.Item6, tuple.Item7, tuple.Item8, tuple.Item9, tuple.Item10, tuple.Item11, tuple.Item12)), Result<TResult, TError>.Error);
		}

		public static Result<TResult, TError> Map<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TError, TResult>(this Result<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13), TError> result, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> selector)
		{
			if (selector == null) throw new ArgumentNullException(nameof(selector));

			return result.Match(tuple => Result<TResult, TError>.Success(selector(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5, tuple.Item6, tuple.Item7, tuple.Item8, tuple.Item9, tuple.Item10, tuple.Item11, tuple.Item12, tuple.Item13)), Result<TResult, TError>.Error);
		}

		public static Result<TResult, TError> Map<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TError, TResult>(this Result<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14), TError> result, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> selector)
		{
			if (selector == null) throw new ArgumentNullException(nameof(selector));

			return result.Match(tuple => Result<TResult, TError>.Success(selector(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5, tuple.Item6, tuple.Item7, tuple.Item8, tuple.Item9, tuple.Item10, tuple.Item11, tuple.Item12, tuple.Item13, tuple.Item14)), Result<TResult, TError>.Error);
		}

		public static Result<TResult, TError> Map<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TError, TResult>(this Result<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15), TError> result, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> selector)
		{
			if (selector == null) throw new ArgumentNullException(nameof(selector));

			return result.Match(tuple => Result<TResult, TError>.Success(selector(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5, tuple.Item6, tuple.Item7, tuple.Item8, tuple.Item9, tuple.Item10, tuple.Item11, tuple.Item12, tuple.Item13, tuple.Item14, tuple.Item15)), Result<TResult, TError>.Error);
		}

		public static Result<TResult, TError> Map<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TError, TResult>(this Result<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16), TError> result, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> selector)
		{
			if (selector == null) throw new ArgumentNullException(nameof(selector));

			return result.Match(tuple => Result<TResult, TError>.Success(selector(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5, tuple.Item6, tuple.Item7, tuple.Item8, tuple.Item9, tuple.Item10, tuple.Item11, tuple.Item12, tuple.Item13, tuple.Item14, tuple.Item15, tuple.Item16)), Result<TResult, TError>.Error);
		}
    }
}