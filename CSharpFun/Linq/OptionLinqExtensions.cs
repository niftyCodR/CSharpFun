using System;

namespace CSharpFun.Linq
{
    public static class OptionLinqExtensions
    {
        public static Option<TResult> Select<T, TResult>(this Option<T> option, Func<T, TResult> selector)
        {
            if (selector == null) throw new ArgumentNullException(nameof(selector));

            return option.Map(selector);
        }

        public static Option<TResult> SelectMany<T, TIntermediate, TResult>(this Option<T> option, Func<T, Option<TIntermediate>> bind, Func<T, TIntermediate, TResult> selector)
        {
            if (bind == null) throw new ArgumentNullException(nameof(bind));
            if (selector == null) throw new ArgumentNullException(nameof(selector));

            return option.Bind(value => option.Bind(bind).Map(intermediateValue => selector(value, intermediateValue)));
        }

        public static Option<T> Where<T>(this Option<T> option, Func<T, bool> predicate)
        {
            if (predicate == null) throw new ArgumentNullException(nameof(predicate));

            return option.Bind(value => predicate(value) ? option : Option<T>.None);
        }
    }
}