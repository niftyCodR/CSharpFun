using System.Linq;

namespace CSharpFun
{
    public static partial class Option
    {
		public static Option<(T1, T2)> Combine<T1, T2>(Option<T1> o1, Option<T2> o2)
		{
			return HasNone(o1, o2)
                ? Option<(T1, T2)>.None
                : Option<(T1, T2)>.Some((GetValueOrThrow(o1), GetValueOrThrow(o2)));
		}

		public static Option<(T1, T2, T3)> Combine<T1, T2, T3>(Option<T1> o1, Option<T2> o2, Option<T3> o3)
		{
			return HasNone(o1, o2, o3)
                ? Option<(T1, T2, T3)>.None
                : Option<(T1, T2, T3)>.Some((GetValueOrThrow(o1), GetValueOrThrow(o2), GetValueOrThrow(o3)));
		}

		public static Option<(T1, T2, T3, T4)> Combine<T1, T2, T3, T4>(Option<T1> o1, Option<T2> o2, Option<T3> o3, Option<T4> o4)
		{
			return HasNone(o1, o2, o3, o4)
                ? Option<(T1, T2, T3, T4)>.None
                : Option<(T1, T2, T3, T4)>.Some((GetValueOrThrow(o1), GetValueOrThrow(o2), GetValueOrThrow(o3), GetValueOrThrow(o4)));
		}

		public static Option<(T1, T2, T3, T4, T5)> Combine<T1, T2, T3, T4, T5>(Option<T1> o1, Option<T2> o2, Option<T3> o3, Option<T4> o4, Option<T5> o5)
		{
			return HasNone(o1, o2, o3, o4, o5)
                ? Option<(T1, T2, T3, T4, T5)>.None
                : Option<(T1, T2, T3, T4, T5)>.Some((GetValueOrThrow(o1), GetValueOrThrow(o2), GetValueOrThrow(o3), GetValueOrThrow(o4), GetValueOrThrow(o5)));
		}

		public static Option<(T1, T2, T3, T4, T5, T6)> Combine<T1, T2, T3, T4, T5, T6>(Option<T1> o1, Option<T2> o2, Option<T3> o3, Option<T4> o4, Option<T5> o5, Option<T6> o6)
		{
			return HasNone(o1, o2, o3, o4, o5, o6)
                ? Option<(T1, T2, T3, T4, T5, T6)>.None
                : Option<(T1, T2, T3, T4, T5, T6)>.Some((GetValueOrThrow(o1), GetValueOrThrow(o2), GetValueOrThrow(o3), GetValueOrThrow(o4), GetValueOrThrow(o5), GetValueOrThrow(o6)));
		}

		public static Option<(T1, T2, T3, T4, T5, T6, T7)> Combine<T1, T2, T3, T4, T5, T6, T7>(Option<T1> o1, Option<T2> o2, Option<T3> o3, Option<T4> o4, Option<T5> o5, Option<T6> o6, Option<T7> o7)
		{
			return HasNone(o1, o2, o3, o4, o5, o6, o7)
                ? Option<(T1, T2, T3, T4, T5, T6, T7)>.None
                : Option<(T1, T2, T3, T4, T5, T6, T7)>.Some((GetValueOrThrow(o1), GetValueOrThrow(o2), GetValueOrThrow(o3), GetValueOrThrow(o4), GetValueOrThrow(o5), GetValueOrThrow(o6), GetValueOrThrow(o7)));
		}

		public static Option<(T1, T2, T3, T4, T5, T6, T7, T8)> Combine<T1, T2, T3, T4, T5, T6, T7, T8>(Option<T1> o1, Option<T2> o2, Option<T3> o3, Option<T4> o4, Option<T5> o5, Option<T6> o6, Option<T7> o7, Option<T8> o8)
		{
			return HasNone(o1, o2, o3, o4, o5, o6, o7, o8)
                ? Option<(T1, T2, T3, T4, T5, T6, T7, T8)>.None
                : Option<(T1, T2, T3, T4, T5, T6, T7, T8)>.Some((GetValueOrThrow(o1), GetValueOrThrow(o2), GetValueOrThrow(o3), GetValueOrThrow(o4), GetValueOrThrow(o5), GetValueOrThrow(o6), GetValueOrThrow(o7), GetValueOrThrow(o8)));
		}

		public static Option<(T1, T2, T3, T4, T5, T6, T7, T8, T9)> Combine<T1, T2, T3, T4, T5, T6, T7, T8, T9>(Option<T1> o1, Option<T2> o2, Option<T3> o3, Option<T4> o4, Option<T5> o5, Option<T6> o6, Option<T7> o7, Option<T8> o8, Option<T9> o9)
		{
			return HasNone(o1, o2, o3, o4, o5, o6, o7, o8, o9)
                ? Option<(T1, T2, T3, T4, T5, T6, T7, T8, T9)>.None
                : Option<(T1, T2, T3, T4, T5, T6, T7, T8, T9)>.Some((GetValueOrThrow(o1), GetValueOrThrow(o2), GetValueOrThrow(o3), GetValueOrThrow(o4), GetValueOrThrow(o5), GetValueOrThrow(o6), GetValueOrThrow(o7), GetValueOrThrow(o8), GetValueOrThrow(o9)));
		}

		public static Option<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10)> Combine<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(Option<T1> o1, Option<T2> o2, Option<T3> o3, Option<T4> o4, Option<T5> o5, Option<T6> o6, Option<T7> o7, Option<T8> o8, Option<T9> o9, Option<T10> o10)
		{
			return HasNone(o1, o2, o3, o4, o5, o6, o7, o8, o9, o10)
                ? Option<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10)>.None
                : Option<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10)>.Some((GetValueOrThrow(o1), GetValueOrThrow(o2), GetValueOrThrow(o3), GetValueOrThrow(o4), GetValueOrThrow(o5), GetValueOrThrow(o6), GetValueOrThrow(o7), GetValueOrThrow(o8), GetValueOrThrow(o9), GetValueOrThrow(o10)));
		}

		public static Option<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11)> Combine<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(Option<T1> o1, Option<T2> o2, Option<T3> o3, Option<T4> o4, Option<T5> o5, Option<T6> o6, Option<T7> o7, Option<T8> o8, Option<T9> o9, Option<T10> o10, Option<T11> o11)
		{
			return HasNone(o1, o2, o3, o4, o5, o6, o7, o8, o9, o10, o11)
                ? Option<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11)>.None
                : Option<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11)>.Some((GetValueOrThrow(o1), GetValueOrThrow(o2), GetValueOrThrow(o3), GetValueOrThrow(o4), GetValueOrThrow(o5), GetValueOrThrow(o6), GetValueOrThrow(o7), GetValueOrThrow(o8), GetValueOrThrow(o9), GetValueOrThrow(o10), GetValueOrThrow(o11)));
		}

		public static Option<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12)> Combine<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(Option<T1> o1, Option<T2> o2, Option<T3> o3, Option<T4> o4, Option<T5> o5, Option<T6> o6, Option<T7> o7, Option<T8> o8, Option<T9> o9, Option<T10> o10, Option<T11> o11, Option<T12> o12)
		{
			return HasNone(o1, o2, o3, o4, o5, o6, o7, o8, o9, o10, o11, o12)
                ? Option<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12)>.None
                : Option<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12)>.Some((GetValueOrThrow(o1), GetValueOrThrow(o2), GetValueOrThrow(o3), GetValueOrThrow(o4), GetValueOrThrow(o5), GetValueOrThrow(o6), GetValueOrThrow(o7), GetValueOrThrow(o8), GetValueOrThrow(o9), GetValueOrThrow(o10), GetValueOrThrow(o11), GetValueOrThrow(o12)));
		}

		public static Option<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13)> Combine<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(Option<T1> o1, Option<T2> o2, Option<T3> o3, Option<T4> o4, Option<T5> o5, Option<T6> o6, Option<T7> o7, Option<T8> o8, Option<T9> o9, Option<T10> o10, Option<T11> o11, Option<T12> o12, Option<T13> o13)
		{
			return HasNone(o1, o2, o3, o4, o5, o6, o7, o8, o9, o10, o11, o12, o13)
                ? Option<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13)>.None
                : Option<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13)>.Some((GetValueOrThrow(o1), GetValueOrThrow(o2), GetValueOrThrow(o3), GetValueOrThrow(o4), GetValueOrThrow(o5), GetValueOrThrow(o6), GetValueOrThrow(o7), GetValueOrThrow(o8), GetValueOrThrow(o9), GetValueOrThrow(o10), GetValueOrThrow(o11), GetValueOrThrow(o12), GetValueOrThrow(o13)));
		}

		public static Option<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14)> Combine<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(Option<T1> o1, Option<T2> o2, Option<T3> o3, Option<T4> o4, Option<T5> o5, Option<T6> o6, Option<T7> o7, Option<T8> o8, Option<T9> o9, Option<T10> o10, Option<T11> o11, Option<T12> o12, Option<T13> o13, Option<T14> o14)
		{
			return HasNone(o1, o2, o3, o4, o5, o6, o7, o8, o9, o10, o11, o12, o13, o14)
                ? Option<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14)>.None
                : Option<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14)>.Some((GetValueOrThrow(o1), GetValueOrThrow(o2), GetValueOrThrow(o3), GetValueOrThrow(o4), GetValueOrThrow(o5), GetValueOrThrow(o6), GetValueOrThrow(o7), GetValueOrThrow(o8), GetValueOrThrow(o9), GetValueOrThrow(o10), GetValueOrThrow(o11), GetValueOrThrow(o12), GetValueOrThrow(o13), GetValueOrThrow(o14)));
		}

		public static Option<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15)> Combine<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(Option<T1> o1, Option<T2> o2, Option<T3> o3, Option<T4> o4, Option<T5> o5, Option<T6> o6, Option<T7> o7, Option<T8> o8, Option<T9> o9, Option<T10> o10, Option<T11> o11, Option<T12> o12, Option<T13> o13, Option<T14> o14, Option<T15> o15)
		{
			return HasNone(o1, o2, o3, o4, o5, o6, o7, o8, o9, o10, o11, o12, o13, o14, o15)
                ? Option<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15)>.None
                : Option<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15)>.Some((GetValueOrThrow(o1), GetValueOrThrow(o2), GetValueOrThrow(o3), GetValueOrThrow(o4), GetValueOrThrow(o5), GetValueOrThrow(o6), GetValueOrThrow(o7), GetValueOrThrow(o8), GetValueOrThrow(o9), GetValueOrThrow(o10), GetValueOrThrow(o11), GetValueOrThrow(o12), GetValueOrThrow(o13), GetValueOrThrow(o14), GetValueOrThrow(o15)));
		}

		public static Option<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16)> Combine<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(Option<T1> o1, Option<T2> o2, Option<T3> o3, Option<T4> o4, Option<T5> o5, Option<T6> o6, Option<T7> o7, Option<T8> o8, Option<T9> o9, Option<T10> o10, Option<T11> o11, Option<T12> o12, Option<T13> o13, Option<T14> o14, Option<T15> o15, Option<T16> o16)
		{
			return HasNone(o1, o2, o3, o4, o5, o6, o7, o8, o9, o10, o11, o12, o13, o14, o15, o16)
                ? Option<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16)>.None
                : Option<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16)>.Some((GetValueOrThrow(o1), GetValueOrThrow(o2), GetValueOrThrow(o3), GetValueOrThrow(o4), GetValueOrThrow(o5), GetValueOrThrow(o6), GetValueOrThrow(o7), GetValueOrThrow(o8), GetValueOrThrow(o9), GetValueOrThrow(o10), GetValueOrThrow(o11), GetValueOrThrow(o12), GetValueOrThrow(o13), GetValueOrThrow(o14), GetValueOrThrow(o15), GetValueOrThrow(o16)));
		}

		public static Option<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17)> Combine<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(Option<T1> o1, Option<T2> o2, Option<T3> o3, Option<T4> o4, Option<T5> o5, Option<T6> o6, Option<T7> o7, Option<T8> o8, Option<T9> o9, Option<T10> o10, Option<T11> o11, Option<T12> o12, Option<T13> o13, Option<T14> o14, Option<T15> o15, Option<T16> o16, Option<T17> o17)
		{
			return HasNone(o1, o2, o3, o4, o5, o6, o7, o8, o9, o10, o11, o12, o13, o14, o15, o16, o17)
                ? Option<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17)>.None
                : Option<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17)>.Some((GetValueOrThrow(o1), GetValueOrThrow(o2), GetValueOrThrow(o3), GetValueOrThrow(o4), GetValueOrThrow(o5), GetValueOrThrow(o6), GetValueOrThrow(o7), GetValueOrThrow(o8), GetValueOrThrow(o9), GetValueOrThrow(o10), GetValueOrThrow(o11), GetValueOrThrow(o12), GetValueOrThrow(o13), GetValueOrThrow(o14), GetValueOrThrow(o15), GetValueOrThrow(o16), GetValueOrThrow(o17)));
		}

		public static Option<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18)> Combine<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(Option<T1> o1, Option<T2> o2, Option<T3> o3, Option<T4> o4, Option<T5> o5, Option<T6> o6, Option<T7> o7, Option<T8> o8, Option<T9> o9, Option<T10> o10, Option<T11> o11, Option<T12> o12, Option<T13> o13, Option<T14> o14, Option<T15> o15, Option<T16> o16, Option<T17> o17, Option<T18> o18)
		{
			return HasNone(o1, o2, o3, o4, o5, o6, o7, o8, o9, o10, o11, o12, o13, o14, o15, o16, o17, o18)
                ? Option<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18)>.None
                : Option<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18)>.Some((GetValueOrThrow(o1), GetValueOrThrow(o2), GetValueOrThrow(o3), GetValueOrThrow(o4), GetValueOrThrow(o5), GetValueOrThrow(o6), GetValueOrThrow(o7), GetValueOrThrow(o8), GetValueOrThrow(o9), GetValueOrThrow(o10), GetValueOrThrow(o11), GetValueOrThrow(o12), GetValueOrThrow(o13), GetValueOrThrow(o14), GetValueOrThrow(o15), GetValueOrThrow(o16), GetValueOrThrow(o17), GetValueOrThrow(o18)));
		}

		public static Option<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19)> Combine<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(Option<T1> o1, Option<T2> o2, Option<T3> o3, Option<T4> o4, Option<T5> o5, Option<T6> o6, Option<T7> o7, Option<T8> o8, Option<T9> o9, Option<T10> o10, Option<T11> o11, Option<T12> o12, Option<T13> o13, Option<T14> o14, Option<T15> o15, Option<T16> o16, Option<T17> o17, Option<T18> o18, Option<T19> o19)
		{
			return HasNone(o1, o2, o3, o4, o5, o6, o7, o8, o9, o10, o11, o12, o13, o14, o15, o16, o17, o18, o19)
                ? Option<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19)>.None
                : Option<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19)>.Some((GetValueOrThrow(o1), GetValueOrThrow(o2), GetValueOrThrow(o3), GetValueOrThrow(o4), GetValueOrThrow(o5), GetValueOrThrow(o6), GetValueOrThrow(o7), GetValueOrThrow(o8), GetValueOrThrow(o9), GetValueOrThrow(o10), GetValueOrThrow(o11), GetValueOrThrow(o12), GetValueOrThrow(o13), GetValueOrThrow(o14), GetValueOrThrow(o15), GetValueOrThrow(o16), GetValueOrThrow(o17), GetValueOrThrow(o18), GetValueOrThrow(o19)));
		}

		public static Option<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20)> Combine<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(Option<T1> o1, Option<T2> o2, Option<T3> o3, Option<T4> o4, Option<T5> o5, Option<T6> o6, Option<T7> o7, Option<T8> o8, Option<T9> o9, Option<T10> o10, Option<T11> o11, Option<T12> o12, Option<T13> o13, Option<T14> o14, Option<T15> o15, Option<T16> o16, Option<T17> o17, Option<T18> o18, Option<T19> o19, Option<T20> o20)
		{
			return HasNone(o1, o2, o3, o4, o5, o6, o7, o8, o9, o10, o11, o12, o13, o14, o15, o16, o17, o18, o19, o20)
                ? Option<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20)>.None
                : Option<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20)>.Some((GetValueOrThrow(o1), GetValueOrThrow(o2), GetValueOrThrow(o3), GetValueOrThrow(o4), GetValueOrThrow(o5), GetValueOrThrow(o6), GetValueOrThrow(o7), GetValueOrThrow(o8), GetValueOrThrow(o9), GetValueOrThrow(o10), GetValueOrThrow(o11), GetValueOrThrow(o12), GetValueOrThrow(o13), GetValueOrThrow(o14), GetValueOrThrow(o15), GetValueOrThrow(o16), GetValueOrThrow(o17), GetValueOrThrow(o18), GetValueOrThrow(o19), GetValueOrThrow(o20)));
		}

		private static bool HasNone(params Option<Unit>[] options)
        {
            return options.Any(o => o.IsNone);
        }
    }
}