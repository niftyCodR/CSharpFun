using System;

namespace CSharpFun.Ext
{
	public static partial class FnExtensions
	{
		public static Action Ignore(this Func<Unit> fn) => () => fn();

        public static Action<T1, T2> Ignore<T1, T2>(this Func<T1, T2, Unit> fn) => (t1, t2) => fn(t1, t2);

        public static Action<T1, T2, T3> Ignore<T1, T2, T3>(this Func<T1, T2, T3, Unit> fn) => (t1, t2, t3) => fn(t1, t2, t3);

        public static Action<T1, T2, T3, T4> Ignore<T1, T2, T3, T4>(this Func<T1, T2, T3, T4, Unit> fn) => (t1, t2, t3, t4) => fn(t1, t2, t3, t4);

        public static Action<T1, T2, T3, T4, T5> Ignore<T1, T2, T3, T4, T5>(this Func<T1, T2, T3, T4, T5, Unit> fn) => (t1, t2, t3, t4, t5) => fn(t1, t2, t3, t4, t5);

        public static Action<T1, T2, T3, T4, T5, T6> Ignore<T1, T2, T3, T4, T5, T6>(this Func<T1, T2, T3, T4, T5, T6, Unit> fn) => (t1, t2, t3, t4, t5, t6) => fn(t1, t2, t3, t4, t5, t6);

        public static Action<T1, T2, T3, T4, T5, T6, T7> Ignore<T1, T2, T3, T4, T5, T6, T7>(this Func<T1, T2, T3, T4, T5, T6, T7, Unit> fn) => (t1, t2, t3, t4, t5, t6, t7) => fn(t1, t2, t3, t4, t5, t6, t7);

        public static Action<T1, T2, T3, T4, T5, T6, T7, T8> Ignore<T1, T2, T3, T4, T5, T6, T7, T8>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, Unit> fn) => (t1, t2, t3, t4, t5, t6, t7, t8) => fn(t1, t2, t3, t4, t5, t6, t7, t8);

        public static Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> Ignore<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, Unit> fn) => (t1, t2, t3, t4, t5, t6, t7, t8, t9) => fn(t1, t2, t3, t4, t5, t6, t7, t8, t9);

        public static Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> Ignore<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, Unit> fn) => (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10) => fn(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10);

        public static Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> Ignore<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, Unit> fn) => (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11) => fn(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11);

        public static Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Ignore<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, Unit> fn) => (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12) => fn(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12);

        public static Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> Ignore<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, Unit> fn) => (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13) => fn(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13);

        public static Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> Ignore<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, Unit> fn) => (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14) => fn(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14);

        public static Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> Ignore<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, Unit> fn) => (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15) => fn(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15);

        public static Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> Ignore<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, Unit> fn) => (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16) => fn(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16);
	}
}