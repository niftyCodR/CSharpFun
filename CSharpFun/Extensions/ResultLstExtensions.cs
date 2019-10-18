namespace CSharpFun
{
    public static class ResultLstExtensions
    {
        public static Result<T, Lst<TError>> ErrorsAsList<T, TError>(this Result<T, TError> result) => result;

        public static Lst<T> AsLst<T, TError>(this Result<T, TError> result)
        {
            return result.Match(
                value => new Lst<T>(value),
                _ => new Lst<T>()
            );
        }
    }
}