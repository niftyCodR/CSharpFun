using System;

namespace CSharpFun
{
    public static partial class Fn
    {
        public static T Id<T>(T input)
        {
            return input;
        }

        public static TResult Pipe<T, TResult>(this T value, Func<T, TResult> fn)
        {
            return fn(value);
        }

        public static Func<T1, T3> Compose<T1, T2, T3>(this Func<T1, T2> fn, Func<T2, T3> fn2)
        {
            return t1 => fn2(fn(t1));
        }
    }
}