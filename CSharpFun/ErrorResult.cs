using System;

namespace CSharpFun
{
    public struct ErrorResult<T>
    {
        public T Value { get; }

        public ErrorResult(T value)
        {
            if (ReferenceEquals(null, value))
                throw new ArgumentNullException(nameof(value));

            Value = value;
        }
    }
}