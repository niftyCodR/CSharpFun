using System;

namespace CSharpFun
{
    public static partial class Result
    {
		public static Result<TResult, TError> Bind<T, TError, TResult>(this Result<T, TError> result, Func<T, Result<TResult, TError>> bind)
        {
			return result.Match(bind, Result<TResult, TError>.Error);
        }

		public static Result<T, TResultError> BindError<T, TError, TResultError>(this Result<T, TError> result, Func<TError, Result<T, TResultError>> bind)
        {
            return result.Match(Result<T, TResultError>.Success, bind);
        }

		public static Result<TResult, TError> Bind<T1, T2, TError, TResult>(this Result<(T1, T2), TError> result, Func<T1, T2, Result<TResult, TError>> bind)
		{
			return result.Match(tuple => bind(tuple.Item1, tuple.Item2), Result<TResult, TError>.Error);
		}

		public static Result<(T1, T2), TResultError> BindError<T1, T2, TError, TResultError>(this Result<(T1, T2), TError> result, Func<TError, Result<(T1, T2), TResultError>> bind)
        {
            return result.Match(Result<(T1, T2), TResultError>.Success, bind);
        }

		public static Result<TResult, TError> Bind<T1, T2, T3, TError, TResult>(this Result<(T1, T2, T3), TError> result, Func<T1, T2, T3, Result<TResult, TError>> bind)
		{
			return result.Match(tuple => bind(tuple.Item1, tuple.Item2, tuple.Item3), Result<TResult, TError>.Error);
		}

		public static Result<(T1, T2, T3), TResultError> BindError<T1, T2, T3, TError, TResultError>(this Result<(T1, T2, T3), TError> result, Func<TError, Result<(T1, T2, T3), TResultError>> bind)
        {
            return result.Match(Result<(T1, T2, T3), TResultError>.Success, bind);
        }

		public static Result<TResult, TError> Bind<T1, T2, T3, T4, TError, TResult>(this Result<(T1, T2, T3, T4), TError> result, Func<T1, T2, T3, T4, Result<TResult, TError>> bind)
		{
			return result.Match(tuple => bind(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4), Result<TResult, TError>.Error);
		}

		public static Result<(T1, T2, T3, T4), TResultError> BindError<T1, T2, T3, T4, TError, TResultError>(this Result<(T1, T2, T3, T4), TError> result, Func<TError, Result<(T1, T2, T3, T4), TResultError>> bind)
        {
            return result.Match(Result<(T1, T2, T3, T4), TResultError>.Success, bind);
        }

		public static Result<TResult, TError> Bind<T1, T2, T3, T4, T5, TError, TResult>(this Result<(T1, T2, T3, T4, T5), TError> result, Func<T1, T2, T3, T4, T5, Result<TResult, TError>> bind)
		{
			return result.Match(tuple => bind(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5), Result<TResult, TError>.Error);
		}

		public static Result<(T1, T2, T3, T4, T5), TResultError> BindError<T1, T2, T3, T4, T5, TError, TResultError>(this Result<(T1, T2, T3, T4, T5), TError> result, Func<TError, Result<(T1, T2, T3, T4, T5), TResultError>> bind)
        {
            return result.Match(Result<(T1, T2, T3, T4, T5), TResultError>.Success, bind);
        }

		public static Result<TResult, TError> Bind<T1, T2, T3, T4, T5, T6, TError, TResult>(this Result<(T1, T2, T3, T4, T5, T6), TError> result, Func<T1, T2, T3, T4, T5, T6, Result<TResult, TError>> bind)
		{
			return result.Match(tuple => bind(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5, tuple.Item6), Result<TResult, TError>.Error);
		}

		public static Result<(T1, T2, T3, T4, T5, T6), TResultError> BindError<T1, T2, T3, T4, T5, T6, TError, TResultError>(this Result<(T1, T2, T3, T4, T5, T6), TError> result, Func<TError, Result<(T1, T2, T3, T4, T5, T6), TResultError>> bind)
        {
            return result.Match(Result<(T1, T2, T3, T4, T5, T6), TResultError>.Success, bind);
        }

		public static Result<TResult, TError> Bind<T1, T2, T3, T4, T5, T6, T7, TError, TResult>(this Result<(T1, T2, T3, T4, T5, T6, T7), TError> result, Func<T1, T2, T3, T4, T5, T6, T7, Result<TResult, TError>> bind)
		{
			return result.Match(tuple => bind(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5, tuple.Item6, tuple.Item7), Result<TResult, TError>.Error);
		}

		public static Result<(T1, T2, T3, T4, T5, T6, T7), TResultError> BindError<T1, T2, T3, T4, T5, T6, T7, TError, TResultError>(this Result<(T1, T2, T3, T4, T5, T6, T7), TError> result, Func<TError, Result<(T1, T2, T3, T4, T5, T6, T7), TResultError>> bind)
        {
            return result.Match(Result<(T1, T2, T3, T4, T5, T6, T7), TResultError>.Success, bind);
        }

		public static Result<TResult, TError> Bind<T1, T2, T3, T4, T5, T6, T7, T8, TError, TResult>(this Result<(T1, T2, T3, T4, T5, T6, T7, T8), TError> result, Func<T1, T2, T3, T4, T5, T6, T7, T8, Result<TResult, TError>> bind)
		{
			return result.Match(tuple => bind(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5, tuple.Item6, tuple.Item7, tuple.Item8), Result<TResult, TError>.Error);
		}

		public static Result<(T1, T2, T3, T4, T5, T6, T7, T8), TResultError> BindError<T1, T2, T3, T4, T5, T6, T7, T8, TError, TResultError>(this Result<(T1, T2, T3, T4, T5, T6, T7, T8), TError> result, Func<TError, Result<(T1, T2, T3, T4, T5, T6, T7, T8), TResultError>> bind)
        {
            return result.Match(Result<(T1, T2, T3, T4, T5, T6, T7, T8), TResultError>.Success, bind);
        }

		public static Result<TResult, TError> Bind<T1, T2, T3, T4, T5, T6, T7, T8, T9, TError, TResult>(this Result<(T1, T2, T3, T4, T5, T6, T7, T8, T9), TError> result, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, Result<TResult, TError>> bind)
		{
			return result.Match(tuple => bind(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5, tuple.Item6, tuple.Item7, tuple.Item8, tuple.Item9), Result<TResult, TError>.Error);
		}

		public static Result<(T1, T2, T3, T4, T5, T6, T7, T8, T9), TResultError> BindError<T1, T2, T3, T4, T5, T6, T7, T8, T9, TError, TResultError>(this Result<(T1, T2, T3, T4, T5, T6, T7, T8, T9), TError> result, Func<TError, Result<(T1, T2, T3, T4, T5, T6, T7, T8, T9), TResultError>> bind)
        {
            return result.Match(Result<(T1, T2, T3, T4, T5, T6, T7, T8, T9), TResultError>.Success, bind);
        }

		public static Result<TResult, TError> Bind<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TError, TResult>(this Result<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10), TError> result, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, Result<TResult, TError>> bind)
		{
			return result.Match(tuple => bind(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5, tuple.Item6, tuple.Item7, tuple.Item8, tuple.Item9, tuple.Item10), Result<TResult, TError>.Error);
		}

		public static Result<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10), TResultError> BindError<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TError, TResultError>(this Result<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10), TError> result, Func<TError, Result<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10), TResultError>> bind)
        {
            return result.Match(Result<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10), TResultError>.Success, bind);
        }

		public static Result<TResult, TError> Bind<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TError, TResult>(this Result<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11), TError> result, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, Result<TResult, TError>> bind)
		{
			return result.Match(tuple => bind(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5, tuple.Item6, tuple.Item7, tuple.Item8, tuple.Item9, tuple.Item10, tuple.Item11), Result<TResult, TError>.Error);
		}

		public static Result<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11), TResultError> BindError<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TError, TResultError>(this Result<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11), TError> result, Func<TError, Result<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11), TResultError>> bind)
        {
            return result.Match(Result<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11), TResultError>.Success, bind);
        }

		public static Result<TResult, TError> Bind<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TError, TResult>(this Result<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12), TError> result, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, Result<TResult, TError>> bind)
		{
			return result.Match(tuple => bind(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5, tuple.Item6, tuple.Item7, tuple.Item8, tuple.Item9, tuple.Item10, tuple.Item11, tuple.Item12), Result<TResult, TError>.Error);
		}

		public static Result<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12), TResultError> BindError<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TError, TResultError>(this Result<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12), TError> result, Func<TError, Result<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12), TResultError>> bind)
        {
            return result.Match(Result<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12), TResultError>.Success, bind);
        }

		public static Result<TResult, TError> Bind<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TError, TResult>(this Result<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13), TError> result, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, Result<TResult, TError>> bind)
		{
			return result.Match(tuple => bind(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5, tuple.Item6, tuple.Item7, tuple.Item8, tuple.Item9, tuple.Item10, tuple.Item11, tuple.Item12, tuple.Item13), Result<TResult, TError>.Error);
		}

		public static Result<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13), TResultError> BindError<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TError, TResultError>(this Result<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13), TError> result, Func<TError, Result<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13), TResultError>> bind)
        {
            return result.Match(Result<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13), TResultError>.Success, bind);
        }

		public static Result<TResult, TError> Bind<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TError, TResult>(this Result<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14), TError> result, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, Result<TResult, TError>> bind)
		{
			return result.Match(tuple => bind(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5, tuple.Item6, tuple.Item7, tuple.Item8, tuple.Item9, tuple.Item10, tuple.Item11, tuple.Item12, tuple.Item13, tuple.Item14), Result<TResult, TError>.Error);
		}

		public static Result<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14), TResultError> BindError<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TError, TResultError>(this Result<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14), TError> result, Func<TError, Result<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14), TResultError>> bind)
        {
            return result.Match(Result<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14), TResultError>.Success, bind);
        }

		public static Result<TResult, TError> Bind<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TError, TResult>(this Result<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15), TError> result, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, Result<TResult, TError>> bind)
		{
			return result.Match(tuple => bind(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5, tuple.Item6, tuple.Item7, tuple.Item8, tuple.Item9, tuple.Item10, tuple.Item11, tuple.Item12, tuple.Item13, tuple.Item14, tuple.Item15), Result<TResult, TError>.Error);
		}

		public static Result<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15), TResultError> BindError<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TError, TResultError>(this Result<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15), TError> result, Func<TError, Result<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15), TResultError>> bind)
        {
            return result.Match(Result<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15), TResultError>.Success, bind);
        }

		public static Result<TResult, TError> Bind<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TError, TResult>(this Result<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16), TError> result, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, Result<TResult, TError>> bind)
		{
			return result.Match(tuple => bind(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5, tuple.Item6, tuple.Item7, tuple.Item8, tuple.Item9, tuple.Item10, tuple.Item11, tuple.Item12, tuple.Item13, tuple.Item14, tuple.Item15, tuple.Item16), Result<TResult, TError>.Error);
		}

		public static Result<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16), TResultError> BindError<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TError, TResultError>(this Result<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16), TError> result, Func<TError, Result<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16), TResultError>> bind)
        {
            return result.Match(Result<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16), TResultError>.Success, bind);
        }
    }
}
