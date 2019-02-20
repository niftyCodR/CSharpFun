using System;

namespace CSharpFun.Linq
{
    public static class OptionLinqExtensions
    {
        public static Option<TResult> Select<T, TResult>(this Option<T> option, Func<T, TResult> selector)
        {
            return option.Map(selector);
        }

        public static Option<TResult> SelectMany<T, TIntermediate, TResult>(this Option<T> option, Func<T, Option<TIntermediate>> bind, Func<T, TIntermediate, TResult> selector)
        {
            if (option.IsNone)
                return Option<TResult>.None;

            var value = Option.GetValueOrThrow(option);

            var intermediate = option.Bind(bind);

            return intermediate.IsNone ? Option<TResult>.None : Option<TResult>.Some(selector(value, Option.GetValueOrThrow(intermediate)));
        }

        public static Option<T> Where<T>(this Option<T> option, Func<T, bool> predicate)
        {
            return option.Match(value => predicate(value) ? option : Option<T>.None, () => option);
        }
    }
}