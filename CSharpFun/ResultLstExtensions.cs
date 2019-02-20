namespace CSharpFun
{
    public static class ResultLstExtensions
    {
        public static Result<T, Lst<TError>> ErrorsAsList<T, TError>(this Result<T, TError> result) => result;
    }
}