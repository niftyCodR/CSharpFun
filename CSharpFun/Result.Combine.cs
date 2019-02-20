using System.Linq;

namespace CSharpFun
{
    public static partial class Result
    {
		public static Result<(T1, T2), Lst<TError>> Combine<T1, T2, TError>(Result<T1, TError> r1, Result<T2, TError> r2)
		{
			var errors = GetErrors(r1, r2);

            return errors.Length > 0
                ? Result<(T1, T2), Lst<TError>>.Error(new Lst<TError>(errors))
                : Success((GetValueOrThrow(r1), GetValueOrThrow(r2)));
		}

		public static Result<(T1, T2), Lst<TError>> Combine<T1, T2, TError>(Result<T1, Lst<TError>> r1, Result<T2, Lst<TError>> r2)
        {
            var errors = GetErrors(r1, r2);

            return errors.Length > 0
                ? Result<(T1, T2), Lst<TError>>.Error(new Lst<TError>(errors))
                : Success((GetValueOrThrow(r1), GetValueOrThrow(r2)));
        }

		public static Result<(T1, T2, T3), Lst<TError>> Combine<T1, T2, T3, TError>(Result<T1, TError> r1, Result<T2, TError> r2, Result<T3, TError> r3)
		{
			var errors = GetErrors(r1, r2, r3);

            return errors.Length > 0
                ? Result<(T1, T2, T3), Lst<TError>>.Error(new Lst<TError>(errors))
                : Success((GetValueOrThrow(r1), GetValueOrThrow(r2), GetValueOrThrow(r3)));
		}

		public static Result<(T1, T2, T3), Lst<TError>> Combine<T1, T2, T3, TError>(Result<T1, Lst<TError>> r1, Result<T2, Lst<TError>> r2, Result<T3, Lst<TError>> r3)
        {
            var errors = GetErrors(r1, r2);

            return errors.Length > 0
                ? Result<(T1, T2, T3), Lst<TError>>.Error(new Lst<TError>(errors))
                : Success((GetValueOrThrow(r1), GetValueOrThrow(r2), GetValueOrThrow(r3)));
        }

		public static Result<(T1, T2, T3, T4), Lst<TError>> Combine<T1, T2, T3, T4, TError>(Result<T1, TError> r1, Result<T2, TError> r2, Result<T3, TError> r3, Result<T4, TError> r4)
		{
			var errors = GetErrors(r1, r2, r3, r4);

            return errors.Length > 0
                ? Result<(T1, T2, T3, T4), Lst<TError>>.Error(new Lst<TError>(errors))
                : Success((GetValueOrThrow(r1), GetValueOrThrow(r2), GetValueOrThrow(r3), GetValueOrThrow(r4)));
		}

		public static Result<(T1, T2, T3, T4), Lst<TError>> Combine<T1, T2, T3, T4, TError>(Result<T1, Lst<TError>> r1, Result<T2, Lst<TError>> r2, Result<T3, Lst<TError>> r3, Result<T4, Lst<TError>> r4)
        {
            var errors = GetErrors(r1, r2);

            return errors.Length > 0
                ? Result<(T1, T2, T3, T4), Lst<TError>>.Error(new Lst<TError>(errors))
                : Success((GetValueOrThrow(r1), GetValueOrThrow(r2), GetValueOrThrow(r3), GetValueOrThrow(r4)));
        }

		public static Result<(T1, T2, T3, T4, T5), Lst<TError>> Combine<T1, T2, T3, T4, T5, TError>(Result<T1, TError> r1, Result<T2, TError> r2, Result<T3, TError> r3, Result<T4, TError> r4, Result<T5, TError> r5)
		{
			var errors = GetErrors(r1, r2, r3, r4, r5);

            return errors.Length > 0
                ? Result<(T1, T2, T3, T4, T5), Lst<TError>>.Error(new Lst<TError>(errors))
                : Success((GetValueOrThrow(r1), GetValueOrThrow(r2), GetValueOrThrow(r3), GetValueOrThrow(r4), GetValueOrThrow(r5)));
		}

		public static Result<(T1, T2, T3, T4, T5), Lst<TError>> Combine<T1, T2, T3, T4, T5, TError>(Result<T1, Lst<TError>> r1, Result<T2, Lst<TError>> r2, Result<T3, Lst<TError>> r3, Result<T4, Lst<TError>> r4, Result<T5, Lst<TError>> r5)
        {
            var errors = GetErrors(r1, r2);

            return errors.Length > 0
                ? Result<(T1, T2, T3, T4, T5), Lst<TError>>.Error(new Lst<TError>(errors))
                : Success((GetValueOrThrow(r1), GetValueOrThrow(r2), GetValueOrThrow(r3), GetValueOrThrow(r4), GetValueOrThrow(r5)));
        }

		public static Result<(T1, T2, T3, T4, T5, T6), Lst<TError>> Combine<T1, T2, T3, T4, T5, T6, TError>(Result<T1, TError> r1, Result<T2, TError> r2, Result<T3, TError> r3, Result<T4, TError> r4, Result<T5, TError> r5, Result<T6, TError> r6)
		{
			var errors = GetErrors(r1, r2, r3, r4, r5, r6);

            return errors.Length > 0
                ? Result<(T1, T2, T3, T4, T5, T6), Lst<TError>>.Error(new Lst<TError>(errors))
                : Success((GetValueOrThrow(r1), GetValueOrThrow(r2), GetValueOrThrow(r3), GetValueOrThrow(r4), GetValueOrThrow(r5), GetValueOrThrow(r6)));
		}

		public static Result<(T1, T2, T3, T4, T5, T6), Lst<TError>> Combine<T1, T2, T3, T4, T5, T6, TError>(Result<T1, Lst<TError>> r1, Result<T2, Lst<TError>> r2, Result<T3, Lst<TError>> r3, Result<T4, Lst<TError>> r4, Result<T5, Lst<TError>> r5, Result<T6, Lst<TError>> r6)
        {
            var errors = GetErrors(r1, r2);

            return errors.Length > 0
                ? Result<(T1, T2, T3, T4, T5, T6), Lst<TError>>.Error(new Lst<TError>(errors))
                : Success((GetValueOrThrow(r1), GetValueOrThrow(r2), GetValueOrThrow(r3), GetValueOrThrow(r4), GetValueOrThrow(r5), GetValueOrThrow(r6)));
        }

		public static Result<(T1, T2, T3, T4, T5, T6, T7), Lst<TError>> Combine<T1, T2, T3, T4, T5, T6, T7, TError>(Result<T1, TError> r1, Result<T2, TError> r2, Result<T3, TError> r3, Result<T4, TError> r4, Result<T5, TError> r5, Result<T6, TError> r6, Result<T7, TError> r7)
		{
			var errors = GetErrors(r1, r2, r3, r4, r5, r6, r7);

            return errors.Length > 0
                ? Result<(T1, T2, T3, T4, T5, T6, T7), Lst<TError>>.Error(new Lst<TError>(errors))
                : Success((GetValueOrThrow(r1), GetValueOrThrow(r2), GetValueOrThrow(r3), GetValueOrThrow(r4), GetValueOrThrow(r5), GetValueOrThrow(r6), GetValueOrThrow(r7)));
		}

		public static Result<(T1, T2, T3, T4, T5, T6, T7), Lst<TError>> Combine<T1, T2, T3, T4, T5, T6, T7, TError>(Result<T1, Lst<TError>> r1, Result<T2, Lst<TError>> r2, Result<T3, Lst<TError>> r3, Result<T4, Lst<TError>> r4, Result<T5, Lst<TError>> r5, Result<T6, Lst<TError>> r6, Result<T7, Lst<TError>> r7)
        {
            var errors = GetErrors(r1, r2);

            return errors.Length > 0
                ? Result<(T1, T2, T3, T4, T5, T6, T7), Lst<TError>>.Error(new Lst<TError>(errors))
                : Success((GetValueOrThrow(r1), GetValueOrThrow(r2), GetValueOrThrow(r3), GetValueOrThrow(r4), GetValueOrThrow(r5), GetValueOrThrow(r6), GetValueOrThrow(r7)));
        }

		public static Result<(T1, T2, T3, T4, T5, T6, T7, T8), Lst<TError>> Combine<T1, T2, T3, T4, T5, T6, T7, T8, TError>(Result<T1, TError> r1, Result<T2, TError> r2, Result<T3, TError> r3, Result<T4, TError> r4, Result<T5, TError> r5, Result<T6, TError> r6, Result<T7, TError> r7, Result<T8, TError> r8)
		{
			var errors = GetErrors(r1, r2, r3, r4, r5, r6, r7, r8);

            return errors.Length > 0
                ? Result<(T1, T2, T3, T4, T5, T6, T7, T8), Lst<TError>>.Error(new Lst<TError>(errors))
                : Success((GetValueOrThrow(r1), GetValueOrThrow(r2), GetValueOrThrow(r3), GetValueOrThrow(r4), GetValueOrThrow(r5), GetValueOrThrow(r6), GetValueOrThrow(r7), GetValueOrThrow(r8)));
		}

		public static Result<(T1, T2, T3, T4, T5, T6, T7, T8), Lst<TError>> Combine<T1, T2, T3, T4, T5, T6, T7, T8, TError>(Result<T1, Lst<TError>> r1, Result<T2, Lst<TError>> r2, Result<T3, Lst<TError>> r3, Result<T4, Lst<TError>> r4, Result<T5, Lst<TError>> r5, Result<T6, Lst<TError>> r6, Result<T7, Lst<TError>> r7, Result<T8, Lst<TError>> r8)
        {
            var errors = GetErrors(r1, r2);

            return errors.Length > 0
                ? Result<(T1, T2, T3, T4, T5, T6, T7, T8), Lst<TError>>.Error(new Lst<TError>(errors))
                : Success((GetValueOrThrow(r1), GetValueOrThrow(r2), GetValueOrThrow(r3), GetValueOrThrow(r4), GetValueOrThrow(r5), GetValueOrThrow(r6), GetValueOrThrow(r7), GetValueOrThrow(r8)));
        }

		public static Result<(T1, T2, T3, T4, T5, T6, T7, T8, T9), Lst<TError>> Combine<T1, T2, T3, T4, T5, T6, T7, T8, T9, TError>(Result<T1, TError> r1, Result<T2, TError> r2, Result<T3, TError> r3, Result<T4, TError> r4, Result<T5, TError> r5, Result<T6, TError> r6, Result<T7, TError> r7, Result<T8, TError> r8, Result<T9, TError> r9)
		{
			var errors = GetErrors(r1, r2, r3, r4, r5, r6, r7, r8, r9);

            return errors.Length > 0
                ? Result<(T1, T2, T3, T4, T5, T6, T7, T8, T9), Lst<TError>>.Error(new Lst<TError>(errors))
                : Success((GetValueOrThrow(r1), GetValueOrThrow(r2), GetValueOrThrow(r3), GetValueOrThrow(r4), GetValueOrThrow(r5), GetValueOrThrow(r6), GetValueOrThrow(r7), GetValueOrThrow(r8), GetValueOrThrow(r9)));
		}

		public static Result<(T1, T2, T3, T4, T5, T6, T7, T8, T9), Lst<TError>> Combine<T1, T2, T3, T4, T5, T6, T7, T8, T9, TError>(Result<T1, Lst<TError>> r1, Result<T2, Lst<TError>> r2, Result<T3, Lst<TError>> r3, Result<T4, Lst<TError>> r4, Result<T5, Lst<TError>> r5, Result<T6, Lst<TError>> r6, Result<T7, Lst<TError>> r7, Result<T8, Lst<TError>> r8, Result<T9, Lst<TError>> r9)
        {
            var errors = GetErrors(r1, r2);

            return errors.Length > 0
                ? Result<(T1, T2, T3, T4, T5, T6, T7, T8, T9), Lst<TError>>.Error(new Lst<TError>(errors))
                : Success((GetValueOrThrow(r1), GetValueOrThrow(r2), GetValueOrThrow(r3), GetValueOrThrow(r4), GetValueOrThrow(r5), GetValueOrThrow(r6), GetValueOrThrow(r7), GetValueOrThrow(r8), GetValueOrThrow(r9)));
        }

		public static Result<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10), Lst<TError>> Combine<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TError>(Result<T1, TError> r1, Result<T2, TError> r2, Result<T3, TError> r3, Result<T4, TError> r4, Result<T5, TError> r5, Result<T6, TError> r6, Result<T7, TError> r7, Result<T8, TError> r8, Result<T9, TError> r9, Result<T10, TError> r10)
		{
			var errors = GetErrors(r1, r2, r3, r4, r5, r6, r7, r8, r9, r10);

            return errors.Length > 0
                ? Result<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10), Lst<TError>>.Error(new Lst<TError>(errors))
                : Success((GetValueOrThrow(r1), GetValueOrThrow(r2), GetValueOrThrow(r3), GetValueOrThrow(r4), GetValueOrThrow(r5), GetValueOrThrow(r6), GetValueOrThrow(r7), GetValueOrThrow(r8), GetValueOrThrow(r9), GetValueOrThrow(r10)));
		}

		public static Result<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10), Lst<TError>> Combine<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TError>(Result<T1, Lst<TError>> r1, Result<T2, Lst<TError>> r2, Result<T3, Lst<TError>> r3, Result<T4, Lst<TError>> r4, Result<T5, Lst<TError>> r5, Result<T6, Lst<TError>> r6, Result<T7, Lst<TError>> r7, Result<T8, Lst<TError>> r8, Result<T9, Lst<TError>> r9, Result<T10, Lst<TError>> r10)
        {
            var errors = GetErrors(r1, r2);

            return errors.Length > 0
                ? Result<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10), Lst<TError>>.Error(new Lst<TError>(errors))
                : Success((GetValueOrThrow(r1), GetValueOrThrow(r2), GetValueOrThrow(r3), GetValueOrThrow(r4), GetValueOrThrow(r5), GetValueOrThrow(r6), GetValueOrThrow(r7), GetValueOrThrow(r8), GetValueOrThrow(r9), GetValueOrThrow(r10)));
        }

		public static Result<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11), Lst<TError>> Combine<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TError>(Result<T1, TError> r1, Result<T2, TError> r2, Result<T3, TError> r3, Result<T4, TError> r4, Result<T5, TError> r5, Result<T6, TError> r6, Result<T7, TError> r7, Result<T8, TError> r8, Result<T9, TError> r9, Result<T10, TError> r10, Result<T11, TError> r11)
		{
			var errors = GetErrors(r1, r2, r3, r4, r5, r6, r7, r8, r9, r10, r11);

            return errors.Length > 0
                ? Result<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11), Lst<TError>>.Error(new Lst<TError>(errors))
                : Success((GetValueOrThrow(r1), GetValueOrThrow(r2), GetValueOrThrow(r3), GetValueOrThrow(r4), GetValueOrThrow(r5), GetValueOrThrow(r6), GetValueOrThrow(r7), GetValueOrThrow(r8), GetValueOrThrow(r9), GetValueOrThrow(r10), GetValueOrThrow(r11)));
		}

		public static Result<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11), Lst<TError>> Combine<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TError>(Result<T1, Lst<TError>> r1, Result<T2, Lst<TError>> r2, Result<T3, Lst<TError>> r3, Result<T4, Lst<TError>> r4, Result<T5, Lst<TError>> r5, Result<T6, Lst<TError>> r6, Result<T7, Lst<TError>> r7, Result<T8, Lst<TError>> r8, Result<T9, Lst<TError>> r9, Result<T10, Lst<TError>> r10, Result<T11, Lst<TError>> r11)
        {
            var errors = GetErrors(r1, r2);

            return errors.Length > 0
                ? Result<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11), Lst<TError>>.Error(new Lst<TError>(errors))
                : Success((GetValueOrThrow(r1), GetValueOrThrow(r2), GetValueOrThrow(r3), GetValueOrThrow(r4), GetValueOrThrow(r5), GetValueOrThrow(r6), GetValueOrThrow(r7), GetValueOrThrow(r8), GetValueOrThrow(r9), GetValueOrThrow(r10), GetValueOrThrow(r11)));
        }

		public static Result<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12), Lst<TError>> Combine<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TError>(Result<T1, TError> r1, Result<T2, TError> r2, Result<T3, TError> r3, Result<T4, TError> r4, Result<T5, TError> r5, Result<T6, TError> r6, Result<T7, TError> r7, Result<T8, TError> r8, Result<T9, TError> r9, Result<T10, TError> r10, Result<T11, TError> r11, Result<T12, TError> r12)
		{
			var errors = GetErrors(r1, r2, r3, r4, r5, r6, r7, r8, r9, r10, r11, r12);

            return errors.Length > 0
                ? Result<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12), Lst<TError>>.Error(new Lst<TError>(errors))
                : Success((GetValueOrThrow(r1), GetValueOrThrow(r2), GetValueOrThrow(r3), GetValueOrThrow(r4), GetValueOrThrow(r5), GetValueOrThrow(r6), GetValueOrThrow(r7), GetValueOrThrow(r8), GetValueOrThrow(r9), GetValueOrThrow(r10), GetValueOrThrow(r11), GetValueOrThrow(r12)));
		}

		public static Result<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12), Lst<TError>> Combine<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TError>(Result<T1, Lst<TError>> r1, Result<T2, Lst<TError>> r2, Result<T3, Lst<TError>> r3, Result<T4, Lst<TError>> r4, Result<T5, Lst<TError>> r5, Result<T6, Lst<TError>> r6, Result<T7, Lst<TError>> r7, Result<T8, Lst<TError>> r8, Result<T9, Lst<TError>> r9, Result<T10, Lst<TError>> r10, Result<T11, Lst<TError>> r11, Result<T12, Lst<TError>> r12)
        {
            var errors = GetErrors(r1, r2);

            return errors.Length > 0
                ? Result<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12), Lst<TError>>.Error(new Lst<TError>(errors))
                : Success((GetValueOrThrow(r1), GetValueOrThrow(r2), GetValueOrThrow(r3), GetValueOrThrow(r4), GetValueOrThrow(r5), GetValueOrThrow(r6), GetValueOrThrow(r7), GetValueOrThrow(r8), GetValueOrThrow(r9), GetValueOrThrow(r10), GetValueOrThrow(r11), GetValueOrThrow(r12)));
        }

		public static Result<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13), Lst<TError>> Combine<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TError>(Result<T1, TError> r1, Result<T2, TError> r2, Result<T3, TError> r3, Result<T4, TError> r4, Result<T5, TError> r5, Result<T6, TError> r6, Result<T7, TError> r7, Result<T8, TError> r8, Result<T9, TError> r9, Result<T10, TError> r10, Result<T11, TError> r11, Result<T12, TError> r12, Result<T13, TError> r13)
		{
			var errors = GetErrors(r1, r2, r3, r4, r5, r6, r7, r8, r9, r10, r11, r12, r13);

            return errors.Length > 0
                ? Result<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13), Lst<TError>>.Error(new Lst<TError>(errors))
                : Success((GetValueOrThrow(r1), GetValueOrThrow(r2), GetValueOrThrow(r3), GetValueOrThrow(r4), GetValueOrThrow(r5), GetValueOrThrow(r6), GetValueOrThrow(r7), GetValueOrThrow(r8), GetValueOrThrow(r9), GetValueOrThrow(r10), GetValueOrThrow(r11), GetValueOrThrow(r12), GetValueOrThrow(r13)));
		}

		public static Result<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13), Lst<TError>> Combine<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TError>(Result<T1, Lst<TError>> r1, Result<T2, Lst<TError>> r2, Result<T3, Lst<TError>> r3, Result<T4, Lst<TError>> r4, Result<T5, Lst<TError>> r5, Result<T6, Lst<TError>> r6, Result<T7, Lst<TError>> r7, Result<T8, Lst<TError>> r8, Result<T9, Lst<TError>> r9, Result<T10, Lst<TError>> r10, Result<T11, Lst<TError>> r11, Result<T12, Lst<TError>> r12, Result<T13, Lst<TError>> r13)
        {
            var errors = GetErrors(r1, r2);

            return errors.Length > 0
                ? Result<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13), Lst<TError>>.Error(new Lst<TError>(errors))
                : Success((GetValueOrThrow(r1), GetValueOrThrow(r2), GetValueOrThrow(r3), GetValueOrThrow(r4), GetValueOrThrow(r5), GetValueOrThrow(r6), GetValueOrThrow(r7), GetValueOrThrow(r8), GetValueOrThrow(r9), GetValueOrThrow(r10), GetValueOrThrow(r11), GetValueOrThrow(r12), GetValueOrThrow(r13)));
        }

		public static Result<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14), Lst<TError>> Combine<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TError>(Result<T1, TError> r1, Result<T2, TError> r2, Result<T3, TError> r3, Result<T4, TError> r4, Result<T5, TError> r5, Result<T6, TError> r6, Result<T7, TError> r7, Result<T8, TError> r8, Result<T9, TError> r9, Result<T10, TError> r10, Result<T11, TError> r11, Result<T12, TError> r12, Result<T13, TError> r13, Result<T14, TError> r14)
		{
			var errors = GetErrors(r1, r2, r3, r4, r5, r6, r7, r8, r9, r10, r11, r12, r13, r14);

            return errors.Length > 0
                ? Result<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14), Lst<TError>>.Error(new Lst<TError>(errors))
                : Success((GetValueOrThrow(r1), GetValueOrThrow(r2), GetValueOrThrow(r3), GetValueOrThrow(r4), GetValueOrThrow(r5), GetValueOrThrow(r6), GetValueOrThrow(r7), GetValueOrThrow(r8), GetValueOrThrow(r9), GetValueOrThrow(r10), GetValueOrThrow(r11), GetValueOrThrow(r12), GetValueOrThrow(r13), GetValueOrThrow(r14)));
		}

		public static Result<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14), Lst<TError>> Combine<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TError>(Result<T1, Lst<TError>> r1, Result<T2, Lst<TError>> r2, Result<T3, Lst<TError>> r3, Result<T4, Lst<TError>> r4, Result<T5, Lst<TError>> r5, Result<T6, Lst<TError>> r6, Result<T7, Lst<TError>> r7, Result<T8, Lst<TError>> r8, Result<T9, Lst<TError>> r9, Result<T10, Lst<TError>> r10, Result<T11, Lst<TError>> r11, Result<T12, Lst<TError>> r12, Result<T13, Lst<TError>> r13, Result<T14, Lst<TError>> r14)
        {
            var errors = GetErrors(r1, r2);

            return errors.Length > 0
                ? Result<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14), Lst<TError>>.Error(new Lst<TError>(errors))
                : Success((GetValueOrThrow(r1), GetValueOrThrow(r2), GetValueOrThrow(r3), GetValueOrThrow(r4), GetValueOrThrow(r5), GetValueOrThrow(r6), GetValueOrThrow(r7), GetValueOrThrow(r8), GetValueOrThrow(r9), GetValueOrThrow(r10), GetValueOrThrow(r11), GetValueOrThrow(r12), GetValueOrThrow(r13), GetValueOrThrow(r14)));
        }

		public static Result<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15), Lst<TError>> Combine<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TError>(Result<T1, TError> r1, Result<T2, TError> r2, Result<T3, TError> r3, Result<T4, TError> r4, Result<T5, TError> r5, Result<T6, TError> r6, Result<T7, TError> r7, Result<T8, TError> r8, Result<T9, TError> r9, Result<T10, TError> r10, Result<T11, TError> r11, Result<T12, TError> r12, Result<T13, TError> r13, Result<T14, TError> r14, Result<T15, TError> r15)
		{
			var errors = GetErrors(r1, r2, r3, r4, r5, r6, r7, r8, r9, r10, r11, r12, r13, r14, r15);

            return errors.Length > 0
                ? Result<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15), Lst<TError>>.Error(new Lst<TError>(errors))
                : Success((GetValueOrThrow(r1), GetValueOrThrow(r2), GetValueOrThrow(r3), GetValueOrThrow(r4), GetValueOrThrow(r5), GetValueOrThrow(r6), GetValueOrThrow(r7), GetValueOrThrow(r8), GetValueOrThrow(r9), GetValueOrThrow(r10), GetValueOrThrow(r11), GetValueOrThrow(r12), GetValueOrThrow(r13), GetValueOrThrow(r14), GetValueOrThrow(r15)));
		}

		public static Result<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15), Lst<TError>> Combine<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TError>(Result<T1, Lst<TError>> r1, Result<T2, Lst<TError>> r2, Result<T3, Lst<TError>> r3, Result<T4, Lst<TError>> r4, Result<T5, Lst<TError>> r5, Result<T6, Lst<TError>> r6, Result<T7, Lst<TError>> r7, Result<T8, Lst<TError>> r8, Result<T9, Lst<TError>> r9, Result<T10, Lst<TError>> r10, Result<T11, Lst<TError>> r11, Result<T12, Lst<TError>> r12, Result<T13, Lst<TError>> r13, Result<T14, Lst<TError>> r14, Result<T15, Lst<TError>> r15)
        {
            var errors = GetErrors(r1, r2);

            return errors.Length > 0
                ? Result<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15), Lst<TError>>.Error(new Lst<TError>(errors))
                : Success((GetValueOrThrow(r1), GetValueOrThrow(r2), GetValueOrThrow(r3), GetValueOrThrow(r4), GetValueOrThrow(r5), GetValueOrThrow(r6), GetValueOrThrow(r7), GetValueOrThrow(r8), GetValueOrThrow(r9), GetValueOrThrow(r10), GetValueOrThrow(r11), GetValueOrThrow(r12), GetValueOrThrow(r13), GetValueOrThrow(r14), GetValueOrThrow(r15)));
        }

		public static Result<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16), Lst<TError>> Combine<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TError>(Result<T1, TError> r1, Result<T2, TError> r2, Result<T3, TError> r3, Result<T4, TError> r4, Result<T5, TError> r5, Result<T6, TError> r6, Result<T7, TError> r7, Result<T8, TError> r8, Result<T9, TError> r9, Result<T10, TError> r10, Result<T11, TError> r11, Result<T12, TError> r12, Result<T13, TError> r13, Result<T14, TError> r14, Result<T15, TError> r15, Result<T16, TError> r16)
		{
			var errors = GetErrors(r1, r2, r3, r4, r5, r6, r7, r8, r9, r10, r11, r12, r13, r14, r15, r16);

            return errors.Length > 0
                ? Result<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16), Lst<TError>>.Error(new Lst<TError>(errors))
                : Success((GetValueOrThrow(r1), GetValueOrThrow(r2), GetValueOrThrow(r3), GetValueOrThrow(r4), GetValueOrThrow(r5), GetValueOrThrow(r6), GetValueOrThrow(r7), GetValueOrThrow(r8), GetValueOrThrow(r9), GetValueOrThrow(r10), GetValueOrThrow(r11), GetValueOrThrow(r12), GetValueOrThrow(r13), GetValueOrThrow(r14), GetValueOrThrow(r15), GetValueOrThrow(r16)));
		}

		public static Result<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16), Lst<TError>> Combine<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TError>(Result<T1, Lst<TError>> r1, Result<T2, Lst<TError>> r2, Result<T3, Lst<TError>> r3, Result<T4, Lst<TError>> r4, Result<T5, Lst<TError>> r5, Result<T6, Lst<TError>> r6, Result<T7, Lst<TError>> r7, Result<T8, Lst<TError>> r8, Result<T9, Lst<TError>> r9, Result<T10, Lst<TError>> r10, Result<T11, Lst<TError>> r11, Result<T12, Lst<TError>> r12, Result<T13, Lst<TError>> r13, Result<T14, Lst<TError>> r14, Result<T15, Lst<TError>> r15, Result<T16, Lst<TError>> r16)
        {
            var errors = GetErrors(r1, r2);

            return errors.Length > 0
                ? Result<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16), Lst<TError>>.Error(new Lst<TError>(errors))
                : Success((GetValueOrThrow(r1), GetValueOrThrow(r2), GetValueOrThrow(r3), GetValueOrThrow(r4), GetValueOrThrow(r5), GetValueOrThrow(r6), GetValueOrThrow(r7), GetValueOrThrow(r8), GetValueOrThrow(r9), GetValueOrThrow(r10), GetValueOrThrow(r11), GetValueOrThrow(r12), GetValueOrThrow(r13), GetValueOrThrow(r14), GetValueOrThrow(r15), GetValueOrThrow(r16)));
        }

		public static Result<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17), Lst<TError>> Combine<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, TError>(Result<T1, TError> r1, Result<T2, TError> r2, Result<T3, TError> r3, Result<T4, TError> r4, Result<T5, TError> r5, Result<T6, TError> r6, Result<T7, TError> r7, Result<T8, TError> r8, Result<T9, TError> r9, Result<T10, TError> r10, Result<T11, TError> r11, Result<T12, TError> r12, Result<T13, TError> r13, Result<T14, TError> r14, Result<T15, TError> r15, Result<T16, TError> r16, Result<T17, TError> r17)
		{
			var errors = GetErrors(r1, r2, r3, r4, r5, r6, r7, r8, r9, r10, r11, r12, r13, r14, r15, r16, r17);

            return errors.Length > 0
                ? Result<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17), Lst<TError>>.Error(new Lst<TError>(errors))
                : Success((GetValueOrThrow(r1), GetValueOrThrow(r2), GetValueOrThrow(r3), GetValueOrThrow(r4), GetValueOrThrow(r5), GetValueOrThrow(r6), GetValueOrThrow(r7), GetValueOrThrow(r8), GetValueOrThrow(r9), GetValueOrThrow(r10), GetValueOrThrow(r11), GetValueOrThrow(r12), GetValueOrThrow(r13), GetValueOrThrow(r14), GetValueOrThrow(r15), GetValueOrThrow(r16), GetValueOrThrow(r17)));
		}

		public static Result<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17), Lst<TError>> Combine<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, TError>(Result<T1, Lst<TError>> r1, Result<T2, Lst<TError>> r2, Result<T3, Lst<TError>> r3, Result<T4, Lst<TError>> r4, Result<T5, Lst<TError>> r5, Result<T6, Lst<TError>> r6, Result<T7, Lst<TError>> r7, Result<T8, Lst<TError>> r8, Result<T9, Lst<TError>> r9, Result<T10, Lst<TError>> r10, Result<T11, Lst<TError>> r11, Result<T12, Lst<TError>> r12, Result<T13, Lst<TError>> r13, Result<T14, Lst<TError>> r14, Result<T15, Lst<TError>> r15, Result<T16, Lst<TError>> r16, Result<T17, Lst<TError>> r17)
        {
            var errors = GetErrors(r1, r2);

            return errors.Length > 0
                ? Result<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17), Lst<TError>>.Error(new Lst<TError>(errors))
                : Success((GetValueOrThrow(r1), GetValueOrThrow(r2), GetValueOrThrow(r3), GetValueOrThrow(r4), GetValueOrThrow(r5), GetValueOrThrow(r6), GetValueOrThrow(r7), GetValueOrThrow(r8), GetValueOrThrow(r9), GetValueOrThrow(r10), GetValueOrThrow(r11), GetValueOrThrow(r12), GetValueOrThrow(r13), GetValueOrThrow(r14), GetValueOrThrow(r15), GetValueOrThrow(r16), GetValueOrThrow(r17)));
        }

		public static Result<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18), Lst<TError>> Combine<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, TError>(Result<T1, TError> r1, Result<T2, TError> r2, Result<T3, TError> r3, Result<T4, TError> r4, Result<T5, TError> r5, Result<T6, TError> r6, Result<T7, TError> r7, Result<T8, TError> r8, Result<T9, TError> r9, Result<T10, TError> r10, Result<T11, TError> r11, Result<T12, TError> r12, Result<T13, TError> r13, Result<T14, TError> r14, Result<T15, TError> r15, Result<T16, TError> r16, Result<T17, TError> r17, Result<T18, TError> r18)
		{
			var errors = GetErrors(r1, r2, r3, r4, r5, r6, r7, r8, r9, r10, r11, r12, r13, r14, r15, r16, r17, r18);

            return errors.Length > 0
                ? Result<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18), Lst<TError>>.Error(new Lst<TError>(errors))
                : Success((GetValueOrThrow(r1), GetValueOrThrow(r2), GetValueOrThrow(r3), GetValueOrThrow(r4), GetValueOrThrow(r5), GetValueOrThrow(r6), GetValueOrThrow(r7), GetValueOrThrow(r8), GetValueOrThrow(r9), GetValueOrThrow(r10), GetValueOrThrow(r11), GetValueOrThrow(r12), GetValueOrThrow(r13), GetValueOrThrow(r14), GetValueOrThrow(r15), GetValueOrThrow(r16), GetValueOrThrow(r17), GetValueOrThrow(r18)));
		}

		public static Result<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18), Lst<TError>> Combine<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, TError>(Result<T1, Lst<TError>> r1, Result<T2, Lst<TError>> r2, Result<T3, Lst<TError>> r3, Result<T4, Lst<TError>> r4, Result<T5, Lst<TError>> r5, Result<T6, Lst<TError>> r6, Result<T7, Lst<TError>> r7, Result<T8, Lst<TError>> r8, Result<T9, Lst<TError>> r9, Result<T10, Lst<TError>> r10, Result<T11, Lst<TError>> r11, Result<T12, Lst<TError>> r12, Result<T13, Lst<TError>> r13, Result<T14, Lst<TError>> r14, Result<T15, Lst<TError>> r15, Result<T16, Lst<TError>> r16, Result<T17, Lst<TError>> r17, Result<T18, Lst<TError>> r18)
        {
            var errors = GetErrors(r1, r2);

            return errors.Length > 0
                ? Result<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18), Lst<TError>>.Error(new Lst<TError>(errors))
                : Success((GetValueOrThrow(r1), GetValueOrThrow(r2), GetValueOrThrow(r3), GetValueOrThrow(r4), GetValueOrThrow(r5), GetValueOrThrow(r6), GetValueOrThrow(r7), GetValueOrThrow(r8), GetValueOrThrow(r9), GetValueOrThrow(r10), GetValueOrThrow(r11), GetValueOrThrow(r12), GetValueOrThrow(r13), GetValueOrThrow(r14), GetValueOrThrow(r15), GetValueOrThrow(r16), GetValueOrThrow(r17), GetValueOrThrow(r18)));
        }

		public static Result<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19), Lst<TError>> Combine<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, TError>(Result<T1, TError> r1, Result<T2, TError> r2, Result<T3, TError> r3, Result<T4, TError> r4, Result<T5, TError> r5, Result<T6, TError> r6, Result<T7, TError> r7, Result<T8, TError> r8, Result<T9, TError> r9, Result<T10, TError> r10, Result<T11, TError> r11, Result<T12, TError> r12, Result<T13, TError> r13, Result<T14, TError> r14, Result<T15, TError> r15, Result<T16, TError> r16, Result<T17, TError> r17, Result<T18, TError> r18, Result<T19, TError> r19)
		{
			var errors = GetErrors(r1, r2, r3, r4, r5, r6, r7, r8, r9, r10, r11, r12, r13, r14, r15, r16, r17, r18, r19);

            return errors.Length > 0
                ? Result<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19), Lst<TError>>.Error(new Lst<TError>(errors))
                : Success((GetValueOrThrow(r1), GetValueOrThrow(r2), GetValueOrThrow(r3), GetValueOrThrow(r4), GetValueOrThrow(r5), GetValueOrThrow(r6), GetValueOrThrow(r7), GetValueOrThrow(r8), GetValueOrThrow(r9), GetValueOrThrow(r10), GetValueOrThrow(r11), GetValueOrThrow(r12), GetValueOrThrow(r13), GetValueOrThrow(r14), GetValueOrThrow(r15), GetValueOrThrow(r16), GetValueOrThrow(r17), GetValueOrThrow(r18), GetValueOrThrow(r19)));
		}

		public static Result<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19), Lst<TError>> Combine<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, TError>(Result<T1, Lst<TError>> r1, Result<T2, Lst<TError>> r2, Result<T3, Lst<TError>> r3, Result<T4, Lst<TError>> r4, Result<T5, Lst<TError>> r5, Result<T6, Lst<TError>> r6, Result<T7, Lst<TError>> r7, Result<T8, Lst<TError>> r8, Result<T9, Lst<TError>> r9, Result<T10, Lst<TError>> r10, Result<T11, Lst<TError>> r11, Result<T12, Lst<TError>> r12, Result<T13, Lst<TError>> r13, Result<T14, Lst<TError>> r14, Result<T15, Lst<TError>> r15, Result<T16, Lst<TError>> r16, Result<T17, Lst<TError>> r17, Result<T18, Lst<TError>> r18, Result<T19, Lst<TError>> r19)
        {
            var errors = GetErrors(r1, r2);

            return errors.Length > 0
                ? Result<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19), Lst<TError>>.Error(new Lst<TError>(errors))
                : Success((GetValueOrThrow(r1), GetValueOrThrow(r2), GetValueOrThrow(r3), GetValueOrThrow(r4), GetValueOrThrow(r5), GetValueOrThrow(r6), GetValueOrThrow(r7), GetValueOrThrow(r8), GetValueOrThrow(r9), GetValueOrThrow(r10), GetValueOrThrow(r11), GetValueOrThrow(r12), GetValueOrThrow(r13), GetValueOrThrow(r14), GetValueOrThrow(r15), GetValueOrThrow(r16), GetValueOrThrow(r17), GetValueOrThrow(r18), GetValueOrThrow(r19)));
        }

		public static Result<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20), Lst<TError>> Combine<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, TError>(Result<T1, TError> r1, Result<T2, TError> r2, Result<T3, TError> r3, Result<T4, TError> r4, Result<T5, TError> r5, Result<T6, TError> r6, Result<T7, TError> r7, Result<T8, TError> r8, Result<T9, TError> r9, Result<T10, TError> r10, Result<T11, TError> r11, Result<T12, TError> r12, Result<T13, TError> r13, Result<T14, TError> r14, Result<T15, TError> r15, Result<T16, TError> r16, Result<T17, TError> r17, Result<T18, TError> r18, Result<T19, TError> r19, Result<T20, TError> r20)
		{
			var errors = GetErrors(r1, r2, r3, r4, r5, r6, r7, r8, r9, r10, r11, r12, r13, r14, r15, r16, r17, r18, r19, r20);

            return errors.Length > 0
                ? Result<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20), Lst<TError>>.Error(new Lst<TError>(errors))
                : Success((GetValueOrThrow(r1), GetValueOrThrow(r2), GetValueOrThrow(r3), GetValueOrThrow(r4), GetValueOrThrow(r5), GetValueOrThrow(r6), GetValueOrThrow(r7), GetValueOrThrow(r8), GetValueOrThrow(r9), GetValueOrThrow(r10), GetValueOrThrow(r11), GetValueOrThrow(r12), GetValueOrThrow(r13), GetValueOrThrow(r14), GetValueOrThrow(r15), GetValueOrThrow(r16), GetValueOrThrow(r17), GetValueOrThrow(r18), GetValueOrThrow(r19), GetValueOrThrow(r20)));
		}

		public static Result<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20), Lst<TError>> Combine<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, TError>(Result<T1, Lst<TError>> r1, Result<T2, Lst<TError>> r2, Result<T3, Lst<TError>> r3, Result<T4, Lst<TError>> r4, Result<T5, Lst<TError>> r5, Result<T6, Lst<TError>> r6, Result<T7, Lst<TError>> r7, Result<T8, Lst<TError>> r8, Result<T9, Lst<TError>> r9, Result<T10, Lst<TError>> r10, Result<T11, Lst<TError>> r11, Result<T12, Lst<TError>> r12, Result<T13, Lst<TError>> r13, Result<T14, Lst<TError>> r14, Result<T15, Lst<TError>> r15, Result<T16, Lst<TError>> r16, Result<T17, Lst<TError>> r17, Result<T18, Lst<TError>> r18, Result<T19, Lst<TError>> r19, Result<T20, Lst<TError>> r20)
        {
            var errors = GetErrors(r1, r2);

            return errors.Length > 0
                ? Result<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20), Lst<TError>>.Error(new Lst<TError>(errors))
                : Success((GetValueOrThrow(r1), GetValueOrThrow(r2), GetValueOrThrow(r3), GetValueOrThrow(r4), GetValueOrThrow(r5), GetValueOrThrow(r6), GetValueOrThrow(r7), GetValueOrThrow(r8), GetValueOrThrow(r9), GetValueOrThrow(r10), GetValueOrThrow(r11), GetValueOrThrow(r12), GetValueOrThrow(r13), GetValueOrThrow(r14), GetValueOrThrow(r15), GetValueOrThrow(r16), GetValueOrThrow(r17), GetValueOrThrow(r18), GetValueOrThrow(r19), GetValueOrThrow(r20)));
        }

        private static TError[] GetErrors<TError>(params Result<Unit, TError>[] results)
        {
            return results
				.Where(r => r.IsError)
				.Select(GetErrorOrThrow)
				.ToArray();
        }

		private static TError[] GetErrors<TError>(params Result<Unit, Lst<TError>>[] results)
        {
            return results
				.Where(r => r.IsError)
				.SelectMany(res => res.GetErrorOrThrow())
				.ToArray();
        }
    }
}
