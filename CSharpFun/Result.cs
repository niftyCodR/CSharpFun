using System;
using System.Collections.Generic;

namespace CSharpFun
{
    public struct Result<T, TError> : IEquatable<Result<T, TError>>, IEquatable<T>
    {
        private readonly ResultState _state;
        private readonly T _value;
        private readonly TError _error;
        private static readonly Result<T, TError> NotInitialized = new Result<T, TError>(ResultState.NotInitialized, default, default);

        private Result(ResultState state, T value, TError error)
        {
            _state = state;
            _value = value;
            _error = error;
        }

        public static Result<T, TError> Success(T value)
        {
            if(ReferenceEquals(null, value))
                throw new ArgumentNullException(nameof(value));

            return new Result<T, TError>(ResultState.Success, value, default);
        }

        public static Result<T, TError> Error(TError error)
        {
            if (ReferenceEquals(null, error))
                throw new ArgumentNullException(nameof(error));

            return new Result<T, TError>(ResultState.Error, default, error);
        }

        public bool IsSuccess => _state == ResultState.Success;

        public bool IsError => _state == ResultState.Error;

        public TResult Match<TResult>(Func<T, TResult> onSuccess, Func<TError, TResult> onError)
        {
            if (onSuccess == null) throw new ArgumentNullException(nameof(onSuccess));
            if (onError == null) throw new ArgumentNullException(nameof(onError));

            switch (_state)
            {
                case ResultState.Success:
                    return onSuccess(_value);
                case ResultState.Error:
                    return onError(_error);
                case ResultState.NotInitialized:
                    throw new InvalidOperationException("The result has not been initialized with an non-null result value or error.");
                default:
                    throw new InvalidOperationException("Bug: Result object is in an unknown state.");
            }
        }

        #region Equality Implementation

        public bool Equals(Result<T, TError> other)
        {
            switch (_state)
            {
                case ResultState.NotInitialized:
                    return other._state == ResultState.NotInitialized;
                case ResultState.Success:
                    return other._state == ResultState.Success && EqualityComparer<T>.Default.Equals(_value, other._value);
                case ResultState.Error:
                    return other._state == ResultState.Error && EqualityComparer<TError>.Default.Equals(_error, other._error);
                default:
                    throw new InvalidOperationException("Bug: Result object is in an unknown state.");
            }
        }

        public bool Equals(T other)
        {
            return Match(val => Equals(val, other), _ => false);
        }

        public override bool Equals(object obj)
        {
            return obj is Result<T, TError> other && Equals(other);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                if (_state == ResultState.NotInitialized)
                    return 0;

                return (_state.GetHashCode() * 397)
                       ^ Match(value => value.GetHashCode(), error => error.GetHashCode());
            }
        }

        public static bool operator ==(Result<T, TError> a, SuccessResult<T> b)
        {
            Result<T, TError> result = b;

            return a.Equals(result);
        }

        public static bool operator !=(Result<T, TError> a, SuccessResult<T> b) => !(a == b);

        public static bool operator ==(SuccessResult<T> a, Result<T, TError> b) => b == a;

        public static bool operator !=(SuccessResult<T> a, Result<T, TError> b) => !(a == b);

        public static bool operator ==(Result<T, TError> a, ErrorResult<TError> b)
        {
            Result<T, TError> result = b;

            return a.Equals(result);
        }

        public static bool operator !=(Result<T, TError> a, ErrorResult<TError> b) => !(a == b);

        public static bool operator ==(ErrorResult<TError> a, Result<T, TError> b) => b == a;

        public static bool operator !=(ErrorResult<TError> a, Result<T, TError> b) => !(a == b);

        public static bool operator ==(Result<T, TError> a, T b) => a.Equals(b);

        public static bool operator !=(Result<T, TError> a, T b) => !(a == b);

        public static bool operator ==(T a, Result<T, TError> b) => b == a;

        public static bool operator !=(T a, Result<T, TError> b) => !(a == b);

        #endregion

        #region Casting Operators

        public static implicit operator Result<T, TError>(SuccessResult<T> result) => result.Value == null ? NotInitialized : Success(result.Value);

        public static implicit operator Result<T, TError>(ErrorResult<TError> result) => result.Value == null ? NotInitialized : Error(result.Value);

        public static implicit operator Result<T, Lst<TError>>(Result<T, TError> result)
        {
            return result.Match(Result<T, Lst<TError>>.Success, error => Result<T, Lst<TError>>.Error(new Lst<TError>(error)));
        }

        public static implicit operator Result<Unit, TError>(Result<T, TError> result) => result.Map(_ => Unit.Value);

        public static implicit operator Option<T>(Result<T, TError> result) => result.Match(Option<T>.Some, _ => Option<T>.None);

        #endregion

        private enum ResultState
        {
            NotInitialized, Success, Error
        }
    }

    public static partial class Result
    {
        public static SuccessResult<T> Success<T>(T value) => new SuccessResult<T>(value);

        public static ErrorResult<TError> Error<TError>(TError error) => new ErrorResult<TError>(error);

        public static Result<T, TError> If<T, TError>(bool condition, T then, TError @else)
        {
            if (condition)
                return Success(then);

            return Error(@else);
        }

        public static Result<T, TError> If<T, TError>(bool condition, Func<T> then, Func<TError> @else)
        {
            if (condition)
                return Success(then());

            return Error(@else());
        }

        public static Result<T, TError> IfNot<T, TError>(bool condition, T then, TError @else)
        {
            if (!condition)
                return Success(then);

            return Error(@else);
        }

        public static Result<T, TError> IfNot<T, TError>(bool condition, Func<T> then, Func<TError> @else)
        {
            if (!condition)
                return Success(then());

            return Error(@else());
        }

        public static T GetValueOrThrow<T, TError>(this Result<T, TError> result)
        {
            return result.Match(
                val => val,
                _ => throw new ArgumentException("Result represents an error , cannot extract value.", nameof(result))
            );
        }

        public static TError GetErrorOrThrow<T, TError>(this Result<T, TError> result)
        {
            return result.Match(
                _ => throw new ArgumentException("Result represents a valid value, cannot extract error.", nameof(result)),
                val => val
            );
        }

        public static bool TryGetValue<T, TError>(this Result<T, TError> result, out T value)
        {
            result.Deconstruct(out var isSuccess, out value, out _);

            return isSuccess;
        }

        public static bool TryGetError<T, TError>(this Result<T, TError> result, out TError error)
        {
            result.Deconstruct(out var isSuccess, out _, out error);

            return !isSuccess;
        }

        public static void Deconstruct<T, TError>(this Result<T, TError> result, out bool isSuccess, out T value, out TError error)
        {
            isSuccess = result.IsSuccess;
            value = result.Match(val => val, _ => default);
            error = result.Match(_ => default, err => err);
        }

        public static T GetValueOr<T, TError>(this Result<T, TError> result, T fallback)
        {
            return result.Match(val => val, _ => fallback);
        }

        public static TError GetErrorOr<T, TError>(this Result<T, TError> result, TError fallback)
        {
            return result.Match(_ => fallback, error => error);
        }
    }
}