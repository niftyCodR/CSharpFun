using System;

namespace CSharpFun
{
    public static class ResultOptionExtensions
    {
        public static Result<T, TError> WithError<T, TError>(this Option<T> option, TError error)
        {
            return option.Match(Result<T, TError>.Success, () => Result<T, TError>.Error(error));
        }

        public static Result<T, Lst<TError>> WithErrors<T, TError>(this Option<T> option, TError error)
        {
            if (error == null) throw new ArgumentNullException(nameof(error));
            return option.Match(Result<T, Lst<TError>>.Success, () => Result<T, Lst<TError>>.Error(new Lst<TError>(error)));
        }

        public static Result<Unit, TError> WithSomeAsError<TError>(this Option<TError> option)
        {
            return option.Match(Result<Unit, TError>.Error, () => Result<Unit, TError>.Success(Unit.Value));
        }
    }
}