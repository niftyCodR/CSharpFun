using System;

namespace CSharpFun
{
    public struct SuccessResult<T>
    {
        public T Value { get; }

        public SuccessResult(T value)
        {
            if (ReferenceEquals(null, value))
                throw new ArgumentNullException(nameof(value));

            Value = value;
        }
    }
}