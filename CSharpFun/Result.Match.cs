using System;

namespace CSharpFun
{
    public static partial class Result
    {
		public static TResult Match<T, TError, TResult>(this Result<T, TError> result, Func<TError, TResult> onError) where T : TResult
        {
            return result.Match(value => value, onError);
        }

		public static Result<T, TError> OnSuccess<T, TError>(this Result<T, TError> result, Action<T> onSuccess)
		{
			return result.Match(value =>
		    {
		        onSuccess(value);
		        return result;
		    }, _ => result);
		}

		public static Result<T, TError> OnError<T, TError>(this Result<T, TError> result, Action<TError> onError)
		{
			return result.Match(_ => result, error =>
		    {
		        onError(error);
		        return result;
		    });
		}

		public static TResult Match<T1, T2, TError, TResult>(this Result<(T1, T2), TError> result, Func<T1, T2, TResult> onSuccess, Func<TError, TResult> onError)
		{
			return result.Match(tuple => onSuccess(tuple.Item1, tuple.Item2), onError);
		}

		public static Result<(T1, T2), TError> OnSuccess<T1, T2, TError>(this Result<(T1, T2), TError> result, Action<T1, T2> onSuccess)
		{
			return result.Match(tuple =>
		    {
		        onSuccess(tuple.Item1, tuple.Item2);
		        return result;
		    }, _ => result);
		}

		public static Result<(T1, T2), TError> OnError<T1, T2, TError>(this Result<(T1, T2), TError> result, Action<TError> onError)
		{
			return result.Match(_ => result, error =>
		    {
		        onError(error);
		        return result;
		    });
		}

		public static TResult Match<T1, T2, T3, TError, TResult>(this Result<(T1, T2, T3), TError> result, Func<T1, T2, T3, TResult> onSuccess, Func<TError, TResult> onError)
		{
			return result.Match(tuple => onSuccess(tuple.Item1, tuple.Item2, tuple.Item3), onError);
		}

		public static Result<(T1, T2, T3), TError> OnSuccess<T1, T2, T3, TError>(this Result<(T1, T2, T3), TError> result, Action<T1, T2, T3> onSuccess)
		{
			return result.Match(tuple =>
		    {
		        onSuccess(tuple.Item1, tuple.Item2, tuple.Item3);
		        return result;
		    }, _ => result);
		}

		public static Result<(T1, T2, T3), TError> OnError<T1, T2, T3, TError>(this Result<(T1, T2, T3), TError> result, Action<TError> onError)
		{
			return result.Match(_ => result, error =>
		    {
		        onError(error);
		        return result;
		    });
		}

		public static TResult Match<T1, T2, T3, T4, TError, TResult>(this Result<(T1, T2, T3, T4), TError> result, Func<T1, T2, T3, T4, TResult> onSuccess, Func<TError, TResult> onError)
		{
			return result.Match(tuple => onSuccess(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4), onError);
		}

		public static Result<(T1, T2, T3, T4), TError> OnSuccess<T1, T2, T3, T4, TError>(this Result<(T1, T2, T3, T4), TError> result, Action<T1, T2, T3, T4> onSuccess)
		{
			return result.Match(tuple =>
		    {
		        onSuccess(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4);
		        return result;
		    }, _ => result);
		}

		public static Result<(T1, T2, T3, T4), TError> OnError<T1, T2, T3, T4, TError>(this Result<(T1, T2, T3, T4), TError> result, Action<TError> onError)
		{
			return result.Match(_ => result, error =>
		    {
		        onError(error);
		        return result;
		    });
		}

		public static TResult Match<T1, T2, T3, T4, T5, TError, TResult>(this Result<(T1, T2, T3, T4, T5), TError> result, Func<T1, T2, T3, T4, T5, TResult> onSuccess, Func<TError, TResult> onError)
		{
			return result.Match(tuple => onSuccess(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5), onError);
		}

		public static Result<(T1, T2, T3, T4, T5), TError> OnSuccess<T1, T2, T3, T4, T5, TError>(this Result<(T1, T2, T3, T4, T5), TError> result, Action<T1, T2, T3, T4, T5> onSuccess)
		{
			return result.Match(tuple =>
		    {
		        onSuccess(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5);
		        return result;
		    }, _ => result);
		}

		public static Result<(T1, T2, T3, T4, T5), TError> OnError<T1, T2, T3, T4, T5, TError>(this Result<(T1, T2, T3, T4, T5), TError> result, Action<TError> onError)
		{
			return result.Match(_ => result, error =>
		    {
		        onError(error);
		        return result;
		    });
		}

		public static TResult Match<T1, T2, T3, T4, T5, T6, TError, TResult>(this Result<(T1, T2, T3, T4, T5, T6), TError> result, Func<T1, T2, T3, T4, T5, T6, TResult> onSuccess, Func<TError, TResult> onError)
		{
			return result.Match(tuple => onSuccess(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5, tuple.Item6), onError);
		}

		public static Result<(T1, T2, T3, T4, T5, T6), TError> OnSuccess<T1, T2, T3, T4, T5, T6, TError>(this Result<(T1, T2, T3, T4, T5, T6), TError> result, Action<T1, T2, T3, T4, T5, T6> onSuccess)
		{
			return result.Match(tuple =>
		    {
		        onSuccess(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5, tuple.Item6);
		        return result;
		    }, _ => result);
		}

		public static Result<(T1, T2, T3, T4, T5, T6), TError> OnError<T1, T2, T3, T4, T5, T6, TError>(this Result<(T1, T2, T3, T4, T5, T6), TError> result, Action<TError> onError)
		{
			return result.Match(_ => result, error =>
		    {
		        onError(error);
		        return result;
		    });
		}

		public static TResult Match<T1, T2, T3, T4, T5, T6, T7, TError, TResult>(this Result<(T1, T2, T3, T4, T5, T6, T7), TError> result, Func<T1, T2, T3, T4, T5, T6, T7, TResult> onSuccess, Func<TError, TResult> onError)
		{
			return result.Match(tuple => onSuccess(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5, tuple.Item6, tuple.Item7), onError);
		}

		public static Result<(T1, T2, T3, T4, T5, T6, T7), TError> OnSuccess<T1, T2, T3, T4, T5, T6, T7, TError>(this Result<(T1, T2, T3, T4, T5, T6, T7), TError> result, Action<T1, T2, T3, T4, T5, T6, T7> onSuccess)
		{
			return result.Match(tuple =>
		    {
		        onSuccess(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5, tuple.Item6, tuple.Item7);
		        return result;
		    }, _ => result);
		}

		public static Result<(T1, T2, T3, T4, T5, T6, T7), TError> OnError<T1, T2, T3, T4, T5, T6, T7, TError>(this Result<(T1, T2, T3, T4, T5, T6, T7), TError> result, Action<TError> onError)
		{
			return result.Match(_ => result, error =>
		    {
		        onError(error);
		        return result;
		    });
		}

		public static TResult Match<T1, T2, T3, T4, T5, T6, T7, T8, TError, TResult>(this Result<(T1, T2, T3, T4, T5, T6, T7, T8), TError> result, Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> onSuccess, Func<TError, TResult> onError)
		{
			return result.Match(tuple => onSuccess(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5, tuple.Item6, tuple.Item7, tuple.Item8), onError);
		}

		public static Result<(T1, T2, T3, T4, T5, T6, T7, T8), TError> OnSuccess<T1, T2, T3, T4, T5, T6, T7, T8, TError>(this Result<(T1, T2, T3, T4, T5, T6, T7, T8), TError> result, Action<T1, T2, T3, T4, T5, T6, T7, T8> onSuccess)
		{
			return result.Match(tuple =>
		    {
		        onSuccess(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5, tuple.Item6, tuple.Item7, tuple.Item8);
		        return result;
		    }, _ => result);
		}

		public static Result<(T1, T2, T3, T4, T5, T6, T7, T8), TError> OnError<T1, T2, T3, T4, T5, T6, T7, T8, TError>(this Result<(T1, T2, T3, T4, T5, T6, T7, T8), TError> result, Action<TError> onError)
		{
			return result.Match(_ => result, error =>
		    {
		        onError(error);
		        return result;
		    });
		}

		public static TResult Match<T1, T2, T3, T4, T5, T6, T7, T8, T9, TError, TResult>(this Result<(T1, T2, T3, T4, T5, T6, T7, T8, T9), TError> result, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> onSuccess, Func<TError, TResult> onError)
		{
			return result.Match(tuple => onSuccess(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5, tuple.Item6, tuple.Item7, tuple.Item8, tuple.Item9), onError);
		}

		public static Result<(T1, T2, T3, T4, T5, T6, T7, T8, T9), TError> OnSuccess<T1, T2, T3, T4, T5, T6, T7, T8, T9, TError>(this Result<(T1, T2, T3, T4, T5, T6, T7, T8, T9), TError> result, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> onSuccess)
		{
			return result.Match(tuple =>
		    {
		        onSuccess(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5, tuple.Item6, tuple.Item7, tuple.Item8, tuple.Item9);
		        return result;
		    }, _ => result);
		}

		public static Result<(T1, T2, T3, T4, T5, T6, T7, T8, T9), TError> OnError<T1, T2, T3, T4, T5, T6, T7, T8, T9, TError>(this Result<(T1, T2, T3, T4, T5, T6, T7, T8, T9), TError> result, Action<TError> onError)
		{
			return result.Match(_ => result, error =>
		    {
		        onError(error);
		        return result;
		    });
		}

		public static TResult Match<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TError, TResult>(this Result<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10), TError> result, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> onSuccess, Func<TError, TResult> onError)
		{
			return result.Match(tuple => onSuccess(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5, tuple.Item6, tuple.Item7, tuple.Item8, tuple.Item9, tuple.Item10), onError);
		}

		public static Result<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10), TError> OnSuccess<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TError>(this Result<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10), TError> result, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> onSuccess)
		{
			return result.Match(tuple =>
		    {
		        onSuccess(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5, tuple.Item6, tuple.Item7, tuple.Item8, tuple.Item9, tuple.Item10);
		        return result;
		    }, _ => result);
		}

		public static Result<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10), TError> OnError<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TError>(this Result<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10), TError> result, Action<TError> onError)
		{
			return result.Match(_ => result, error =>
		    {
		        onError(error);
		        return result;
		    });
		}

		public static TResult Match<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TError, TResult>(this Result<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11), TError> result, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> onSuccess, Func<TError, TResult> onError)
		{
			return result.Match(tuple => onSuccess(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5, tuple.Item6, tuple.Item7, tuple.Item8, tuple.Item9, tuple.Item10, tuple.Item11), onError);
		}

		public static Result<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11), TError> OnSuccess<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TError>(this Result<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11), TError> result, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> onSuccess)
		{
			return result.Match(tuple =>
		    {
		        onSuccess(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5, tuple.Item6, tuple.Item7, tuple.Item8, tuple.Item9, tuple.Item10, tuple.Item11);
		        return result;
		    }, _ => result);
		}

		public static Result<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11), TError> OnError<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TError>(this Result<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11), TError> result, Action<TError> onError)
		{
			return result.Match(_ => result, error =>
		    {
		        onError(error);
		        return result;
		    });
		}

		public static TResult Match<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TError, TResult>(this Result<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12), TError> result, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> onSuccess, Func<TError, TResult> onError)
		{
			return result.Match(tuple => onSuccess(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5, tuple.Item6, tuple.Item7, tuple.Item8, tuple.Item9, tuple.Item10, tuple.Item11, tuple.Item12), onError);
		}

		public static Result<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12), TError> OnSuccess<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TError>(this Result<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12), TError> result, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> onSuccess)
		{
			return result.Match(tuple =>
		    {
		        onSuccess(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5, tuple.Item6, tuple.Item7, tuple.Item8, tuple.Item9, tuple.Item10, tuple.Item11, tuple.Item12);
		        return result;
		    }, _ => result);
		}

		public static Result<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12), TError> OnError<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TError>(this Result<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12), TError> result, Action<TError> onError)
		{
			return result.Match(_ => result, error =>
		    {
		        onError(error);
		        return result;
		    });
		}

		public static TResult Match<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TError, TResult>(this Result<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13), TError> result, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> onSuccess, Func<TError, TResult> onError)
		{
			return result.Match(tuple => onSuccess(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5, tuple.Item6, tuple.Item7, tuple.Item8, tuple.Item9, tuple.Item10, tuple.Item11, tuple.Item12, tuple.Item13), onError);
		}

		public static Result<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13), TError> OnSuccess<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TError>(this Result<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13), TError> result, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> onSuccess)
		{
			return result.Match(tuple =>
		    {
		        onSuccess(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5, tuple.Item6, tuple.Item7, tuple.Item8, tuple.Item9, tuple.Item10, tuple.Item11, tuple.Item12, tuple.Item13);
		        return result;
		    }, _ => result);
		}

		public static Result<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13), TError> OnError<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TError>(this Result<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13), TError> result, Action<TError> onError)
		{
			return result.Match(_ => result, error =>
		    {
		        onError(error);
		        return result;
		    });
		}

		public static TResult Match<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TError, TResult>(this Result<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14), TError> result, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> onSuccess, Func<TError, TResult> onError)
		{
			return result.Match(tuple => onSuccess(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5, tuple.Item6, tuple.Item7, tuple.Item8, tuple.Item9, tuple.Item10, tuple.Item11, tuple.Item12, tuple.Item13, tuple.Item14), onError);
		}

		public static Result<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14), TError> OnSuccess<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TError>(this Result<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14), TError> result, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> onSuccess)
		{
			return result.Match(tuple =>
		    {
		        onSuccess(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5, tuple.Item6, tuple.Item7, tuple.Item8, tuple.Item9, tuple.Item10, tuple.Item11, tuple.Item12, tuple.Item13, tuple.Item14);
		        return result;
		    }, _ => result);
		}

		public static Result<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14), TError> OnError<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TError>(this Result<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14), TError> result, Action<TError> onError)
		{
			return result.Match(_ => result, error =>
		    {
		        onError(error);
		        return result;
		    });
		}

		public static TResult Match<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TError, TResult>(this Result<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15), TError> result, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> onSuccess, Func<TError, TResult> onError)
		{
			return result.Match(tuple => onSuccess(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5, tuple.Item6, tuple.Item7, tuple.Item8, tuple.Item9, tuple.Item10, tuple.Item11, tuple.Item12, tuple.Item13, tuple.Item14, tuple.Item15), onError);
		}

		public static Result<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15), TError> OnSuccess<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TError>(this Result<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15), TError> result, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> onSuccess)
		{
			return result.Match(tuple =>
		    {
		        onSuccess(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5, tuple.Item6, tuple.Item7, tuple.Item8, tuple.Item9, tuple.Item10, tuple.Item11, tuple.Item12, tuple.Item13, tuple.Item14, tuple.Item15);
		        return result;
		    }, _ => result);
		}

		public static Result<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15), TError> OnError<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TError>(this Result<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15), TError> result, Action<TError> onError)
		{
			return result.Match(_ => result, error =>
		    {
		        onError(error);
		        return result;
		    });
		}

		public static TResult Match<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TError, TResult>(this Result<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16), TError> result, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> onSuccess, Func<TError, TResult> onError)
		{
			return result.Match(tuple => onSuccess(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5, tuple.Item6, tuple.Item7, tuple.Item8, tuple.Item9, tuple.Item10, tuple.Item11, tuple.Item12, tuple.Item13, tuple.Item14, tuple.Item15, tuple.Item16), onError);
		}

		public static Result<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16), TError> OnSuccess<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TError>(this Result<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16), TError> result, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> onSuccess)
		{
			return result.Match(tuple =>
		    {
		        onSuccess(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5, tuple.Item6, tuple.Item7, tuple.Item8, tuple.Item9, tuple.Item10, tuple.Item11, tuple.Item12, tuple.Item13, tuple.Item14, tuple.Item15, tuple.Item16);
		        return result;
		    }, _ => result);
		}

		public static Result<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16), TError> OnError<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TError>(this Result<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16), TError> result, Action<TError> onError)
		{
			return result.Match(_ => result, error =>
		    {
		        onError(error);
		        return result;
		    });
		}
    }
}