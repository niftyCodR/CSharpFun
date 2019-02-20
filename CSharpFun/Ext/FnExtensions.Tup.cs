using System;

namespace CSharpFun.Ext
{
    public static partial class FnExtensions
    {
		public static Func<T1, T2, TResult> Tup<T1, T2, TResult>(this Func<(T1, T2), TResult> fn)
        {
            return (t1, t2) => fn((t1, t2));
        }

		public static Func<T1, T2, T3, TResult> Tup<T1, T2, T3, TResult>(this Func<(T1, T2, T3), TResult> fn)
        {
            return (t1, t2, t3) => fn((t1, t2, t3));
        }

		public static Func<T1, T2, T3, T4, TResult> Tup<T1, T2, T3, T4, TResult>(this Func<(T1, T2, T3, T4), TResult> fn)
        {
            return (t1, t2, t3, t4) => fn((t1, t2, t3, t4));
        }

		public static Func<T1, T2, T3, T4, T5, TResult> Tup<T1, T2, T3, T4, T5, TResult>(this Func<(T1, T2, T3, T4, T5), TResult> fn)
        {
            return (t1, t2, t3, t4, t5) => fn((t1, t2, t3, t4, t5));
        }

		public static Func<T1, T2, T3, T4, T5, T6, TResult> Tup<T1, T2, T3, T4, T5, T6, TResult>(this Func<(T1, T2, T3, T4, T5, T6), TResult> fn)
        {
            return (t1, t2, t3, t4, t5, t6) => fn((t1, t2, t3, t4, t5, t6));
        }

		public static Func<T1, T2, T3, T4, T5, T6, T7, TResult> Tup<T1, T2, T3, T4, T5, T6, T7, TResult>(this Func<(T1, T2, T3, T4, T5, T6, T7), TResult> fn)
        {
            return (t1, t2, t3, t4, t5, t6, t7) => fn((t1, t2, t3, t4, t5, t6, t7));
        }

		public static Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> Tup<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(this Func<(T1, T2, T3, T4, T5, T6, T7, T8), TResult> fn)
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8) => fn((t1, t2, t3, t4, t5, t6, t7, t8));
        }

		public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> Tup<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(this Func<(T1, T2, T3, T4, T5, T6, T7, T8, T9), TResult> fn)
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9) => fn((t1, t2, t3, t4, t5, t6, t7, t8, t9));
        }

		public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> Tup<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(this Func<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10), TResult> fn)
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10) => fn((t1, t2, t3, t4, t5, t6, t7, t8, t9, t10));
        }

		public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> Tup<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(this Func<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11), TResult> fn)
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11) => fn((t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11));
        }

		public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> Tup<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(this Func<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12), TResult> fn)
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12) => fn((t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12));
        }

		public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> Tup<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(this Func<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13), TResult> fn)
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13) => fn((t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13));
        }

		public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> Tup<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this Func<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14), TResult> fn)
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14) => fn((t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14));
        }

		public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> Tup<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this Func<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15), TResult> fn)
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15) => fn((t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15));
        }

		public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> Tup<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this Func<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16), TResult> fn)
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16) => fn((t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16));
        }
	}
}