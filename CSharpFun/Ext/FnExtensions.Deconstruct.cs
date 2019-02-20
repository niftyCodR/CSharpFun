using System;

namespace CSharpFun.Ext
{
    public static partial class FnExtensions
    {
		public static Func<(T1, T2), TResult> Deconstruct<T1, T2, TResult>(this Func<T1, T2, TResult> fn)
        {
            return tuple => fn(tuple.Item1, tuple.Item2);
        }

		public static Func<(T1, T2, T3), TResult> Deconstruct<T1, T2, T3, TResult>(this Func<T1, T2, T3, TResult> fn)
        {
            return tuple => fn(tuple.Item1, tuple.Item2, tuple.Item3);
        }

		public static Func<(T1, T2, T3, T4), TResult> Deconstruct<T1, T2, T3, T4, TResult>(this Func<T1, T2, T3, T4, TResult> fn)
        {
            return tuple => fn(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4);
        }

		public static Func<(T1, T2, T3, T4, T5), TResult> Deconstruct<T1, T2, T3, T4, T5, TResult>(this Func<T1, T2, T3, T4, T5, TResult> fn)
        {
            return tuple => fn(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5);
        }

		public static Func<(T1, T2, T3, T4, T5, T6), TResult> Deconstruct<T1, T2, T3, T4, T5, T6, TResult>(this Func<T1, T2, T3, T4, T5, T6, TResult> fn)
        {
            return tuple => fn(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5, tuple.Item6);
        }

		public static Func<(T1, T2, T3, T4, T5, T6, T7), TResult> Deconstruct<T1, T2, T3, T4, T5, T6, T7, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, TResult> fn)
        {
            return tuple => fn(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5, tuple.Item6, tuple.Item7);
        }

		public static Func<(T1, T2, T3, T4, T5, T6, T7, T8), TResult> Deconstruct<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> fn)
        {
            return tuple => fn(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5, tuple.Item6, tuple.Item7, tuple.Item8);
        }

		public static Func<(T1, T2, T3, T4, T5, T6, T7, T8, T9), TResult> Deconstruct<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> fn)
        {
            return tuple => fn(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5, tuple.Item6, tuple.Item7, tuple.Item8, tuple.Item9);
        }

		public static Func<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10), TResult> Deconstruct<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> fn)
        {
            return tuple => fn(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5, tuple.Item6, tuple.Item7, tuple.Item8, tuple.Item9, tuple.Item10);
        }

		public static Func<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11), TResult> Deconstruct<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> fn)
        {
            return tuple => fn(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5, tuple.Item6, tuple.Item7, tuple.Item8, tuple.Item9, tuple.Item10, tuple.Item11);
        }

		public static Func<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12), TResult> Deconstruct<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> fn)
        {
            return tuple => fn(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5, tuple.Item6, tuple.Item7, tuple.Item8, tuple.Item9, tuple.Item10, tuple.Item11, tuple.Item12);
        }

		public static Func<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13), TResult> Deconstruct<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> fn)
        {
            return tuple => fn(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5, tuple.Item6, tuple.Item7, tuple.Item8, tuple.Item9, tuple.Item10, tuple.Item11, tuple.Item12, tuple.Item13);
        }

		public static Func<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14), TResult> Deconstruct<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> fn)
        {
            return tuple => fn(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5, tuple.Item6, tuple.Item7, tuple.Item8, tuple.Item9, tuple.Item10, tuple.Item11, tuple.Item12, tuple.Item13, tuple.Item14);
        }

		public static Func<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15), TResult> Deconstruct<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> fn)
        {
            return tuple => fn(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5, tuple.Item6, tuple.Item7, tuple.Item8, tuple.Item9, tuple.Item10, tuple.Item11, tuple.Item12, tuple.Item13, tuple.Item14, tuple.Item15);
        }

		public static Func<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16), TResult> Deconstruct<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> fn)
        {
            return tuple => fn(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5, tuple.Item6, tuple.Item7, tuple.Item8, tuple.Item9, tuple.Item10, tuple.Item11, tuple.Item12, tuple.Item13, tuple.Item14, tuple.Item15, tuple.Item16);
        }
	}
}