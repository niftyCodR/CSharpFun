using System;
using System.Threading.Tasks;

namespace CSharpFun.Linq.Async
{
    public static class AsyncOptionLinqExtensions
    {
        public static async Task<Option<T>> ToAsync<T>(this Option<T> result) => await Task.FromResult(result);

        public static async Task<Option<TResult>> Select<T, TResult>(this Task<Option<T>> asyncOption, Func<T, TResult> selector)
        {
            if (asyncOption == null) throw new ArgumentNullException(nameof(asyncOption));
            if (selector == null) throw new ArgumentNullException(nameof(selector));

            var option = await asyncOption;

            return option.Map(selector);
        }

        public static async Task<Option<TResult>> SelectMany<T, TIntermediate, TResult>(this Task<Option<T>> asyncOption, Func<T, Task<Option<TIntermediate>>> bind, Func<T, TIntermediate, TResult> selector)
        {
            if (bind == null) throw new ArgumentNullException(nameof(bind));
            if (selector == null) throw new ArgumentNullException(nameof(selector));

            var option = await asyncOption;

            return await option.Match(
                async value =>
                {
                    var intermediateOption = await bind(value);

                    return intermediateOption.Map(intermediateValue => selector(value, intermediateValue));
                },
                () => Option<TResult>.None.ToAsync()
            );
        }

        public static async Task<Option<T>> Where<T>(this Task<Option<T>> asyncOption, Func<T, bool> predicate)
        {
            if (asyncOption == null) throw new ArgumentNullException(nameof(asyncOption));
            if (predicate == null) throw new ArgumentNullException(nameof(predicate));

            var option = await asyncOption;

            return option.Bind(value => predicate(value) ? option : Option<T>.None);
        }
    }
}