using System;

namespace CSharpFun
{
    /// <summary>
    /// Represents the absence of a value. This is similar to the void return type
    /// in methods, but can be used in multiple places.
    /// Enables an easier transformation model so you can model an <see cref="Action"/>
    /// as a <see cref="Func{Unit}"/> of type <see cref="Unit"/>.
    /// </summary>
    public struct Unit
    {
        public static Unit Value { get; } = default;
    }
}