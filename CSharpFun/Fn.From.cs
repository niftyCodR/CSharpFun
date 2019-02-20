using System;

namespace CSharpFun
{
    public static partial class Fn
    {
		public static Func<Unit> From(Action action)
        {
            return () =>
            {
                action();
                return Unit.Value;
            };
        }

        public static Func<T1, Unit> From<T1>(Action<T1> action)
        {
            return action == null ? null : new Func<T1, Unit>((t1) =>
            {
                action(t1);
                return Unit.Value;
            });
        }

        public static Func<T1, T2, Unit> From<T1, T2>(Action<T1, T2> action)
        {
            return action == null ? null : new Func<T1, T2, Unit>((t1, t2) =>
            {
                action(t1, t2);
                return Unit.Value;
            });
        }

        public static Func<T1, T2, T3, Unit> From<T1, T2, T3>(Action<T1, T2, T3> action)
        {
            return action == null ? null : new Func<T1, T2, T3, Unit>((t1, t2, t3) =>
            {
                action(t1, t2, t3);
                return Unit.Value;
            });
        }

        public static Func<T1, T2, T3, T4, Unit> From<T1, T2, T3, T4>(Action<T1, T2, T3, T4> action)
        {
            return action == null ? null : new Func<T1, T2, T3, T4, Unit>((t1, t2, t3, t4) =>
            {
                action(t1, t2, t3, t4);
                return Unit.Value;
            });
        }

        public static Func<T1, T2, T3, T4, T5, Unit> From<T1, T2, T3, T4, T5>(Action<T1, T2, T3, T4, T5> action)
        {
            return action == null ? null : new Func<T1, T2, T3, T4, T5, Unit>((t1, t2, t3, t4, t5) =>
            {
                action(t1, t2, t3, t4, t5);
                return Unit.Value;
            });
        }

        public static Func<T1, T2, T3, T4, T5, T6, Unit> From<T1, T2, T3, T4, T5, T6>(Action<T1, T2, T3, T4, T5, T6> action)
        {
            return action == null ? null : new Func<T1, T2, T3, T4, T5, T6, Unit>((t1, t2, t3, t4, t5, t6) =>
            {
                action(t1, t2, t3, t4, t5, t6);
                return Unit.Value;
            });
        }

        public static Func<T1, T2, T3, T4, T5, T6, T7, Unit> From<T1, T2, T3, T4, T5, T6, T7>(Action<T1, T2, T3, T4, T5, T6, T7> action)
        {
            return action == null ? null : new Func<T1, T2, T3, T4, T5, T6, T7, Unit>((t1, t2, t3, t4, t5, t6, t7) =>
            {
                action(t1, t2, t3, t4, t5, t6, t7);
                return Unit.Value;
            });
        }

        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, Unit> From<T1, T2, T3, T4, T5, T6, T7, T8>(Action<T1, T2, T3, T4, T5, T6, T7, T8> action)
        {
            return action == null ? null : new Func<T1, T2, T3, T4, T5, T6, T7, T8, Unit>((t1, t2, t3, t4, t5, t6, t7, t8) =>
            {
                action(t1, t2, t3, t4, t5, t6, t7, t8);
                return Unit.Value;
            });
        }

        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, Unit> From<T1, T2, T3, T4, T5, T6, T7, T8, T9>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action)
        {
            return action == null ? null : new Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, Unit>((t1, t2, t3, t4, t5, t6, t7, t8, t9) =>
            {
                action(t1, t2, t3, t4, t5, t6, t7, t8, t9);
                return Unit.Value;
            });
        }

        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, Unit> From<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> action)
        {
            return action == null ? null : new Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, Unit>((t1, t2, t3, t4, t5, t6, t7, t8, t9, t10) =>
            {
                action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10);
                return Unit.Value;
            });
        }

        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, Unit> From<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> action)
        {
            return action == null ? null : new Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, Unit>((t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11) =>
            {
                action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11);
                return Unit.Value;
            });
        }

        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, Unit> From<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> action)
        {
            return action == null ? null : new Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, Unit>((t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12) =>
            {
                action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12);
                return Unit.Value;
            });
        }

        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, Unit> From<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action)
        {
            return action == null ? null : new Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, Unit>((t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13) =>
            {
                action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13);
                return Unit.Value;
            });
        }

        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, Unit> From<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action)
        {
            return action == null ? null : new Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, Unit>((t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14) =>
            {
                action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14);
                return Unit.Value;
            });
        }

        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, Unit> From<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action)
        {
            return action == null ? null : new Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, Unit>((t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15) =>
            {
                action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15);
                return Unit.Value;
            });
        }

        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, Unit> From<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action)
        {
            return action == null ? null : new Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, Unit>((t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16) =>
            {
                action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16);
                return Unit.Value;
            });
        }
    }
}