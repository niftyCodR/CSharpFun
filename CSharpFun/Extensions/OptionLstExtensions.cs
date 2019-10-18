namespace CSharpFun
{
    public static class OptionLstExtensions
    {
        public static Lst<T> ToLst<T>(this Option<T> option)
        {
            return option.Match(
                value => new Lst<T>(value),
                () => new Lst<T>()
            );
        }
    }
}