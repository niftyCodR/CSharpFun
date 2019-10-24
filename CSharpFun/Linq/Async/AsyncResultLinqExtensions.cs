using System;
using System.Threading.Tasks;

namespace CSharpFun.Linq.Async
{
    public static class AsyncResultLinqExtensions
    {
        public static async Task<Result<T, TError>> ToAsync<T, TError>(this Result<T, TError> result) => await Task.FromResult(result);

        public static async Task<Result<TResult, TError>> SelectMany<T, TIntermediate, TResult, TError>(this Task<Result<T, TError>> asyncResult, Func<T, Task<Result<TIntermediate, TError>>> bind, Func<T, TIntermediate, TResult> selector)
        {
            if (bind == null) throw new ArgumentNullException(nameof(bind));
            if (selector == null) throw new ArgumentNullException(nameof(selector));

            var result = await asyncResult;

            return await result.Match(
                onSuccess: async value =>
                {
                    var intermediateResult = await bind(value);

                    return intermediateResult.Map(intermediateValue => selector(value, intermediateValue));
                },
                error => Result<TResult, TError>.Error(error).ToAsync()
            );
        }
    }
}