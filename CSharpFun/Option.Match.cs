using System;
using System.Diagnostics.Contracts;
using System.Threading.Tasks;

namespace CSharpFun
{
	public static partial class Option
    {
		[Pure]
		public static TResult Match<T1, T2, TResult>(this Option<(T1, T2)> option, Func<T1, T2, TResult> onSome, Func<TResult> onNone)
		{
            if (onSome == null) throw new ArgumentNullException(nameof(onSome));
            if (onNone == null) throw new ArgumentNullException(nameof(onNone));

			return option.Match(tuple => onSome(tuple.Item1, tuple.Item2), onNone);
		}

		[Pure]
		public static async Task<TResult> Match<T1, T2, TResult>(this Task<Option<(T1, T2)>> asyncOption, Func<T1, T2, TResult> onSome, Func<TResult> onNone)
		{
			if (asyncOption == null) throw new ArgumentNullException(nameof(asyncOption));
            if (onSome == null) throw new ArgumentNullException(nameof(onSome));
            if (onNone == null) throw new ArgumentNullException(nameof(onNone));

			var option = await asyncOption;

			return option.Match(onSome, onNone);
		}

		public static Option<(T1, T2)> OnSome<T1, T2>(this Option<(T1, T2)> option, Action<T1, T2> onSome)
        {
            return option.Match(
                tuple =>
                {
                    onSome(tuple.Item1, tuple.Item2);
                    return option;
                },
                () => option
            );
        }

		[Pure]
		public static TResult Match<T1, T2, T3, TResult>(this Option<(T1, T2, T3)> option, Func<T1, T2, T3, TResult> onSome, Func<TResult> onNone)
		{
            if (onSome == null) throw new ArgumentNullException(nameof(onSome));
            if (onNone == null) throw new ArgumentNullException(nameof(onNone));

			return option.Match(tuple => onSome(tuple.Item1, tuple.Item2, tuple.Item3), onNone);
		}

		[Pure]
		public static async Task<TResult> Match<T1, T2, T3, TResult>(this Task<Option<(T1, T2, T3)>> asyncOption, Func<T1, T2, T3, TResult> onSome, Func<TResult> onNone)
		{
			if (asyncOption == null) throw new ArgumentNullException(nameof(asyncOption));
            if (onSome == null) throw new ArgumentNullException(nameof(onSome));
            if (onNone == null) throw new ArgumentNullException(nameof(onNone));

			var option = await asyncOption;

			return option.Match(onSome, onNone);
		}

		public static Option<(T1, T2, T3)> OnSome<T1, T2, T3>(this Option<(T1, T2, T3)> option, Action<T1, T2, T3> onSome)
        {
            return option.Match(
                tuple =>
                {
                    onSome(tuple.Item1, tuple.Item2, tuple.Item3);
                    return option;
                },
                () => option
            );
        }

		[Pure]
		public static TResult Match<T1, T2, T3, T4, TResult>(this Option<(T1, T2, T3, T4)> option, Func<T1, T2, T3, T4, TResult> onSome, Func<TResult> onNone)
		{
            if (onSome == null) throw new ArgumentNullException(nameof(onSome));
            if (onNone == null) throw new ArgumentNullException(nameof(onNone));

			return option.Match(tuple => onSome(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4), onNone);
		}

		[Pure]
		public static async Task<TResult> Match<T1, T2, T3, T4, TResult>(this Task<Option<(T1, T2, T3, T4)>> asyncOption, Func<T1, T2, T3, T4, TResult> onSome, Func<TResult> onNone)
		{
			if (asyncOption == null) throw new ArgumentNullException(nameof(asyncOption));
            if (onSome == null) throw new ArgumentNullException(nameof(onSome));
            if (onNone == null) throw new ArgumentNullException(nameof(onNone));

			var option = await asyncOption;

			return option.Match(onSome, onNone);
		}

		public static Option<(T1, T2, T3, T4)> OnSome<T1, T2, T3, T4>(this Option<(T1, T2, T3, T4)> option, Action<T1, T2, T3, T4> onSome)
        {
            return option.Match(
                tuple =>
                {
                    onSome(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4);
                    return option;
                },
                () => option
            );
        }

		[Pure]
		public static TResult Match<T1, T2, T3, T4, T5, TResult>(this Option<(T1, T2, T3, T4, T5)> option, Func<T1, T2, T3, T4, T5, TResult> onSome, Func<TResult> onNone)
		{
            if (onSome == null) throw new ArgumentNullException(nameof(onSome));
            if (onNone == null) throw new ArgumentNullException(nameof(onNone));

			return option.Match(tuple => onSome(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5), onNone);
		}

		[Pure]
		public static async Task<TResult> Match<T1, T2, T3, T4, T5, TResult>(this Task<Option<(T1, T2, T3, T4, T5)>> asyncOption, Func<T1, T2, T3, T4, T5, TResult> onSome, Func<TResult> onNone)
		{
			if (asyncOption == null) throw new ArgumentNullException(nameof(asyncOption));
            if (onSome == null) throw new ArgumentNullException(nameof(onSome));
            if (onNone == null) throw new ArgumentNullException(nameof(onNone));

			var option = await asyncOption;

			return option.Match(onSome, onNone);
		}

		public static Option<(T1, T2, T3, T4, T5)> OnSome<T1, T2, T3, T4, T5>(this Option<(T1, T2, T3, T4, T5)> option, Action<T1, T2, T3, T4, T5> onSome)
        {
            return option.Match(
                tuple =>
                {
                    onSome(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5);
                    return option;
                },
                () => option
            );
        }

		[Pure]
		public static TResult Match<T1, T2, T3, T4, T5, T6, TResult>(this Option<(T1, T2, T3, T4, T5, T6)> option, Func<T1, T2, T3, T4, T5, T6, TResult> onSome, Func<TResult> onNone)
		{
            if (onSome == null) throw new ArgumentNullException(nameof(onSome));
            if (onNone == null) throw new ArgumentNullException(nameof(onNone));

			return option.Match(tuple => onSome(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5, tuple.Item6), onNone);
		}

		[Pure]
		public static async Task<TResult> Match<T1, T2, T3, T4, T5, T6, TResult>(this Task<Option<(T1, T2, T3, T4, T5, T6)>> asyncOption, Func<T1, T2, T3, T4, T5, T6, TResult> onSome, Func<TResult> onNone)
		{
			if (asyncOption == null) throw new ArgumentNullException(nameof(asyncOption));
            if (onSome == null) throw new ArgumentNullException(nameof(onSome));
            if (onNone == null) throw new ArgumentNullException(nameof(onNone));

			var option = await asyncOption;

			return option.Match(onSome, onNone);
		}

		public static Option<(T1, T2, T3, T4, T5, T6)> OnSome<T1, T2, T3, T4, T5, T6>(this Option<(T1, T2, T3, T4, T5, T6)> option, Action<T1, T2, T3, T4, T5, T6> onSome)
        {
            return option.Match(
                tuple =>
                {
                    onSome(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5, tuple.Item6);
                    return option;
                },
                () => option
            );
        }

		[Pure]
		public static TResult Match<T1, T2, T3, T4, T5, T6, T7, TResult>(this Option<(T1, T2, T3, T4, T5, T6, T7)> option, Func<T1, T2, T3, T4, T5, T6, T7, TResult> onSome, Func<TResult> onNone)
		{
            if (onSome == null) throw new ArgumentNullException(nameof(onSome));
            if (onNone == null) throw new ArgumentNullException(nameof(onNone));

			return option.Match(tuple => onSome(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5, tuple.Item6, tuple.Item7), onNone);
		}

		[Pure]
		public static async Task<TResult> Match<T1, T2, T3, T4, T5, T6, T7, TResult>(this Task<Option<(T1, T2, T3, T4, T5, T6, T7)>> asyncOption, Func<T1, T2, T3, T4, T5, T6, T7, TResult> onSome, Func<TResult> onNone)
		{
			if (asyncOption == null) throw new ArgumentNullException(nameof(asyncOption));
            if (onSome == null) throw new ArgumentNullException(nameof(onSome));
            if (onNone == null) throw new ArgumentNullException(nameof(onNone));

			var option = await asyncOption;

			return option.Match(onSome, onNone);
		}

		public static Option<(T1, T2, T3, T4, T5, T6, T7)> OnSome<T1, T2, T3, T4, T5, T6, T7>(this Option<(T1, T2, T3, T4, T5, T6, T7)> option, Action<T1, T2, T3, T4, T5, T6, T7> onSome)
        {
            return option.Match(
                tuple =>
                {
                    onSome(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5, tuple.Item6, tuple.Item7);
                    return option;
                },
                () => option
            );
        }

		[Pure]
		public static TResult Match<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(this Option<(T1, T2, T3, T4, T5, T6, T7, T8)> option, Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> onSome, Func<TResult> onNone)
		{
            if (onSome == null) throw new ArgumentNullException(nameof(onSome));
            if (onNone == null) throw new ArgumentNullException(nameof(onNone));

			return option.Match(tuple => onSome(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5, tuple.Item6, tuple.Item7, tuple.Item8), onNone);
		}

		[Pure]
		public static async Task<TResult> Match<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(this Task<Option<(T1, T2, T3, T4, T5, T6, T7, T8)>> asyncOption, Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> onSome, Func<TResult> onNone)
		{
			if (asyncOption == null) throw new ArgumentNullException(nameof(asyncOption));
            if (onSome == null) throw new ArgumentNullException(nameof(onSome));
            if (onNone == null) throw new ArgumentNullException(nameof(onNone));

			var option = await asyncOption;

			return option.Match(onSome, onNone);
		}

		public static Option<(T1, T2, T3, T4, T5, T6, T7, T8)> OnSome<T1, T2, T3, T4, T5, T6, T7, T8>(this Option<(T1, T2, T3, T4, T5, T6, T7, T8)> option, Action<T1, T2, T3, T4, T5, T6, T7, T8> onSome)
        {
            return option.Match(
                tuple =>
                {
                    onSome(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5, tuple.Item6, tuple.Item7, tuple.Item8);
                    return option;
                },
                () => option
            );
        }

		[Pure]
		public static TResult Match<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(this Option<(T1, T2, T3, T4, T5, T6, T7, T8, T9)> option, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> onSome, Func<TResult> onNone)
		{
            if (onSome == null) throw new ArgumentNullException(nameof(onSome));
            if (onNone == null) throw new ArgumentNullException(nameof(onNone));

			return option.Match(tuple => onSome(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5, tuple.Item6, tuple.Item7, tuple.Item8, tuple.Item9), onNone);
		}

		[Pure]
		public static async Task<TResult> Match<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(this Task<Option<(T1, T2, T3, T4, T5, T6, T7, T8, T9)>> asyncOption, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> onSome, Func<TResult> onNone)
		{
			if (asyncOption == null) throw new ArgumentNullException(nameof(asyncOption));
            if (onSome == null) throw new ArgumentNullException(nameof(onSome));
            if (onNone == null) throw new ArgumentNullException(nameof(onNone));

			var option = await asyncOption;

			return option.Match(onSome, onNone);
		}

		public static Option<(T1, T2, T3, T4, T5, T6, T7, T8, T9)> OnSome<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this Option<(T1, T2, T3, T4, T5, T6, T7, T8, T9)> option, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> onSome)
        {
            return option.Match(
                tuple =>
                {
                    onSome(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5, tuple.Item6, tuple.Item7, tuple.Item8, tuple.Item9);
                    return option;
                },
                () => option
            );
        }

		[Pure]
		public static TResult Match<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(this Option<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10)> option, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> onSome, Func<TResult> onNone)
		{
            if (onSome == null) throw new ArgumentNullException(nameof(onSome));
            if (onNone == null) throw new ArgumentNullException(nameof(onNone));

			return option.Match(tuple => onSome(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5, tuple.Item6, tuple.Item7, tuple.Item8, tuple.Item9, tuple.Item10), onNone);
		}

		[Pure]
		public static async Task<TResult> Match<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(this Task<Option<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10)>> asyncOption, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> onSome, Func<TResult> onNone)
		{
			if (asyncOption == null) throw new ArgumentNullException(nameof(asyncOption));
            if (onSome == null) throw new ArgumentNullException(nameof(onSome));
            if (onNone == null) throw new ArgumentNullException(nameof(onNone));

			var option = await asyncOption;

			return option.Match(onSome, onNone);
		}

		public static Option<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10)> OnSome<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this Option<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10)> option, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> onSome)
        {
            return option.Match(
                tuple =>
                {
                    onSome(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5, tuple.Item6, tuple.Item7, tuple.Item8, tuple.Item9, tuple.Item10);
                    return option;
                },
                () => option
            );
        }

		[Pure]
		public static TResult Match<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(this Option<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11)> option, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> onSome, Func<TResult> onNone)
		{
            if (onSome == null) throw new ArgumentNullException(nameof(onSome));
            if (onNone == null) throw new ArgumentNullException(nameof(onNone));

			return option.Match(tuple => onSome(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5, tuple.Item6, tuple.Item7, tuple.Item8, tuple.Item9, tuple.Item10, tuple.Item11), onNone);
		}

		[Pure]
		public static async Task<TResult> Match<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(this Task<Option<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11)>> asyncOption, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> onSome, Func<TResult> onNone)
		{
			if (asyncOption == null) throw new ArgumentNullException(nameof(asyncOption));
            if (onSome == null) throw new ArgumentNullException(nameof(onSome));
            if (onNone == null) throw new ArgumentNullException(nameof(onNone));

			var option = await asyncOption;

			return option.Match(onSome, onNone);
		}

		public static Option<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11)> OnSome<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this Option<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11)> option, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> onSome)
        {
            return option.Match(
                tuple =>
                {
                    onSome(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5, tuple.Item6, tuple.Item7, tuple.Item8, tuple.Item9, tuple.Item10, tuple.Item11);
                    return option;
                },
                () => option
            );
        }

		[Pure]
		public static TResult Match<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(this Option<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12)> option, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> onSome, Func<TResult> onNone)
		{
            if (onSome == null) throw new ArgumentNullException(nameof(onSome));
            if (onNone == null) throw new ArgumentNullException(nameof(onNone));

			return option.Match(tuple => onSome(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5, tuple.Item6, tuple.Item7, tuple.Item8, tuple.Item9, tuple.Item10, tuple.Item11, tuple.Item12), onNone);
		}

		[Pure]
		public static async Task<TResult> Match<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(this Task<Option<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12)>> asyncOption, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> onSome, Func<TResult> onNone)
		{
			if (asyncOption == null) throw new ArgumentNullException(nameof(asyncOption));
            if (onSome == null) throw new ArgumentNullException(nameof(onSome));
            if (onNone == null) throw new ArgumentNullException(nameof(onNone));

			var option = await asyncOption;

			return option.Match(onSome, onNone);
		}

		public static Option<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12)> OnSome<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this Option<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12)> option, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> onSome)
        {
            return option.Match(
                tuple =>
                {
                    onSome(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5, tuple.Item6, tuple.Item7, tuple.Item8, tuple.Item9, tuple.Item10, tuple.Item11, tuple.Item12);
                    return option;
                },
                () => option
            );
        }

		[Pure]
		public static TResult Match<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(this Option<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13)> option, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> onSome, Func<TResult> onNone)
		{
            if (onSome == null) throw new ArgumentNullException(nameof(onSome));
            if (onNone == null) throw new ArgumentNullException(nameof(onNone));

			return option.Match(tuple => onSome(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5, tuple.Item6, tuple.Item7, tuple.Item8, tuple.Item9, tuple.Item10, tuple.Item11, tuple.Item12, tuple.Item13), onNone);
		}

		[Pure]
		public static async Task<TResult> Match<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(this Task<Option<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13)>> asyncOption, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> onSome, Func<TResult> onNone)
		{
			if (asyncOption == null) throw new ArgumentNullException(nameof(asyncOption));
            if (onSome == null) throw new ArgumentNullException(nameof(onSome));
            if (onNone == null) throw new ArgumentNullException(nameof(onNone));

			var option = await asyncOption;

			return option.Match(onSome, onNone);
		}

		public static Option<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13)> OnSome<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this Option<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13)> option, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> onSome)
        {
            return option.Match(
                tuple =>
                {
                    onSome(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5, tuple.Item6, tuple.Item7, tuple.Item8, tuple.Item9, tuple.Item10, tuple.Item11, tuple.Item12, tuple.Item13);
                    return option;
                },
                () => option
            );
        }

		[Pure]
		public static TResult Match<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this Option<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14)> option, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> onSome, Func<TResult> onNone)
		{
            if (onSome == null) throw new ArgumentNullException(nameof(onSome));
            if (onNone == null) throw new ArgumentNullException(nameof(onNone));

			return option.Match(tuple => onSome(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5, tuple.Item6, tuple.Item7, tuple.Item8, tuple.Item9, tuple.Item10, tuple.Item11, tuple.Item12, tuple.Item13, tuple.Item14), onNone);
		}

		[Pure]
		public static async Task<TResult> Match<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this Task<Option<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14)>> asyncOption, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> onSome, Func<TResult> onNone)
		{
			if (asyncOption == null) throw new ArgumentNullException(nameof(asyncOption));
            if (onSome == null) throw new ArgumentNullException(nameof(onSome));
            if (onNone == null) throw new ArgumentNullException(nameof(onNone));

			var option = await asyncOption;

			return option.Match(onSome, onNone);
		}

		public static Option<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14)> OnSome<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this Option<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14)> option, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> onSome)
        {
            return option.Match(
                tuple =>
                {
                    onSome(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5, tuple.Item6, tuple.Item7, tuple.Item8, tuple.Item9, tuple.Item10, tuple.Item11, tuple.Item12, tuple.Item13, tuple.Item14);
                    return option;
                },
                () => option
            );
        }

		[Pure]
		public static TResult Match<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this Option<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15)> option, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> onSome, Func<TResult> onNone)
		{
            if (onSome == null) throw new ArgumentNullException(nameof(onSome));
            if (onNone == null) throw new ArgumentNullException(nameof(onNone));

			return option.Match(tuple => onSome(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5, tuple.Item6, tuple.Item7, tuple.Item8, tuple.Item9, tuple.Item10, tuple.Item11, tuple.Item12, tuple.Item13, tuple.Item14, tuple.Item15), onNone);
		}

		[Pure]
		public static async Task<TResult> Match<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this Task<Option<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15)>> asyncOption, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> onSome, Func<TResult> onNone)
		{
			if (asyncOption == null) throw new ArgumentNullException(nameof(asyncOption));
            if (onSome == null) throw new ArgumentNullException(nameof(onSome));
            if (onNone == null) throw new ArgumentNullException(nameof(onNone));

			var option = await asyncOption;

			return option.Match(onSome, onNone);
		}

		public static Option<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15)> OnSome<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this Option<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15)> option, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> onSome)
        {
            return option.Match(
                tuple =>
                {
                    onSome(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5, tuple.Item6, tuple.Item7, tuple.Item8, tuple.Item9, tuple.Item10, tuple.Item11, tuple.Item12, tuple.Item13, tuple.Item14, tuple.Item15);
                    return option;
                },
                () => option
            );
        }

		[Pure]
		public static TResult Match<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this Option<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16)> option, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> onSome, Func<TResult> onNone)
		{
            if (onSome == null) throw new ArgumentNullException(nameof(onSome));
            if (onNone == null) throw new ArgumentNullException(nameof(onNone));

			return option.Match(tuple => onSome(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5, tuple.Item6, tuple.Item7, tuple.Item8, tuple.Item9, tuple.Item10, tuple.Item11, tuple.Item12, tuple.Item13, tuple.Item14, tuple.Item15, tuple.Item16), onNone);
		}

		[Pure]
		public static async Task<TResult> Match<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this Task<Option<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16)>> asyncOption, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> onSome, Func<TResult> onNone)
		{
			if (asyncOption == null) throw new ArgumentNullException(nameof(asyncOption));
            if (onSome == null) throw new ArgumentNullException(nameof(onSome));
            if (onNone == null) throw new ArgumentNullException(nameof(onNone));

			var option = await asyncOption;

			return option.Match(onSome, onNone);
		}

		public static Option<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16)> OnSome<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this Option<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16)> option, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> onSome)
        {
            return option.Match(
                tuple =>
                {
                    onSome(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5, tuple.Item6, tuple.Item7, tuple.Item8, tuple.Item9, tuple.Item10, tuple.Item11, tuple.Item12, tuple.Item13, tuple.Item14, tuple.Item15, tuple.Item16);
                    return option;
                },
                () => option
            );
        }
    }
}