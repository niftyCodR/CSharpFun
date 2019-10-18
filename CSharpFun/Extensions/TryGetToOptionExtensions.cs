using System;
using System.Collections.Generic;

namespace CSharpFun
{
    public static class TryGetToOptionExtensions
    {
        public static Option<TValue> TryGetValue<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key)
        {
            if (dictionary == null) throw new ArgumentNullException(nameof(dictionary));

            return dictionary.TryGetValue(key, out var value) 
                ? Option.Some(value) 
                : Option.None;
        }
    }
}