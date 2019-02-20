using System;

namespace CSharpFun.Ext
{
    public static partial class FnExtensions
    {
		public static Func<TResult> Apply<T1, TResult>(this Func<T1, TResult> fn, T1 value)
        {
            return () => fn(value);
        }

        public static Func<T2, TResult> Apply<T1, T2, TResult>(this Func<T1, T2, TResult> fn, T1 value)
        {
            return (value2) => fn(value, value2);
        }

        public static Func<T2, T3, TResult> Apply<T1, T2, T3, TResult>(this Func<T1, T2, T3, TResult> fn, T1 value)
        {
            return (value2, value3) => fn(value, value2, value3);
        }

        public static Func<T2, T3, T4, TResult> Apply<T1, T2, T3, T4, TResult>(this Func<T1, T2, T3, T4, TResult> fn, T1 value)
        {
            return (value2, value3, value4) => fn(value, value2, value3, value4);
        }

        public static Func<T2, T3, T4, T5, TResult> Apply<T1, T2, T3, T4, T5, TResult>(this Func<T1, T2, T3, T4, T5, TResult> fn, T1 value)
        {
            return (value2, value3, value4, value5) => fn(value, value2, value3, value4, value5);
        }

        public static Func<T2, T3, T4, T5, T6, TResult> Apply<T1, T2, T3, T4, T5, T6, TResult>(this Func<T1, T2, T3, T4, T5, T6, TResult> fn, T1 value)
        {
            return (value2, value3, value4, value5, value6) => fn(value, value2, value3, value4, value5, value6);
        }

        public static Func<T2, T3, T4, T5, T6, T7, TResult> Apply<T1, T2, T3, T4, T5, T6, T7, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, TResult> fn, T1 value)
        {
            return (value2, value3, value4, value5, value6, value7) => fn(value, value2, value3, value4, value5, value6, value7);
        }

        public static Func<T2, T3, T4, T5, T6, T7, T8, TResult> Apply<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> fn, T1 value)
        {
            return (value2, value3, value4, value5, value6, value7, value8) => fn(value, value2, value3, value4, value5, value6, value7, value8);
        }

        public static Func<T2, T3, T4, T5, T6, T7, T8, T9, TResult> Apply<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> fn, T1 value)
        {
            return (value2, value3, value4, value5, value6, value7, value8, value9) => fn(value, value2, value3, value4, value5, value6, value7, value8, value9);
        }

        public static Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> Apply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> fn, T1 value)
        {
            return (value2, value3, value4, value5, value6, value7, value8, value9, value10) => fn(value, value2, value3, value4, value5, value6, value7, value8, value9, value10);
        }

        public static Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> Apply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> fn, T1 value)
        {
            return (value2, value3, value4, value5, value6, value7, value8, value9, value10, value11) => fn(value, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11);
        }

        public static Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> Apply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> fn, T1 value)
        {
            return (value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12) => fn(value, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12);
        }

        public static Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> Apply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> fn, T1 value)
        {
            return (value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13) => fn(value, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13);
        }

        public static Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> Apply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> fn, T1 value)
        {
            return (value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14) => fn(value, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14);
        }

        public static Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> Apply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> fn, T1 value)
        {
            return (value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15) => fn(value, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15);
        }

        public static Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> Apply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> fn, T1 value)
        {
            return (value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15, value16) => fn(value, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15, value16);
        }
    }
}