using System;

namespace CSharpFun.Linq
{
    public static class ResultLinqExtensions
    {
        public static Result<TResult, TError> Select<T, TResult, TError>(this Result<T, TError> result, Func<T, TResult> selector)
        {
            return result.Map(selector);
        }

        public static Result<TResult, TError> SelectMany<T, TIntermediate, TResult, TError>(this Result<T, TError> result, Func<T, Result<TIntermediate, TError>> bind, Func<T, TIntermediate, TResult> selector)
        {
            return result.Bind(bind).Map(intermediate => selector(result.Match(val => val, _ => default), intermediate));
        }

        public static Result<TResult, TError> SelectMany<T, TIntermediate, TResult, TError>(this Result<T, TError> result, Func<T, Result<TIntermediate, TError>> bind, Func<T, TIntermediate, Result<TResult, TError>> selector)
        {
            return result.Bind(bind).Bind(intermediate => selector(result.Match(val => val, _ => default), intermediate));
        }
    }
}