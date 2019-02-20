namespace CSharpFun
{
    /// <summary>
    /// The "joker" brings "CSharpFun" to your project when you add it with
    /// <code>using static CSharpFun.Joker;</code>.
    /// This enables you to use constructor functions for the provided types
    /// similar to functional programming languages like F#.
    /// <example>
    /// <code>
    /// namespace MyApp
    /// {
    ///     using static CSharpFun.Joker;
    ///
    ///     public class MyClass
    ///     {
    ///         public void MyMethod()
    ///         {
    ///             var some = Some(3);
    ///             var none = None;
    ///         }
    ///     }
    /// }
    /// 
    /// </code>
    /// </example>
    /// </summary>
    public static class Joker
    {
        public static Option<T> Some<T>(T value) => Option.Some(value);

        public static NoneOption None => Option.None;

        public static SuccessResult<T> Success<T>(T value) => new SuccessResult<T>(value);

        public static ErrorResult<TError> Error<TError>(TError error) => new ErrorResult<TError>(error);
    }
}