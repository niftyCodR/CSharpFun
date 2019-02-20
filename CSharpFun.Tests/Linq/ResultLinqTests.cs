using CSharpFun.Linq;
using Xunit;

namespace CSharpFun.Tests.Linq
{
    public class ResultLinqTests
    {
        [Fact]
        public void Linq_SelectMany_IsSupported()
        {
            var succ = Result<int, int>.Success(3);
            var err = Result<int, int>.Error(1);

            var z = from i in succ
                from j in err
                select i + j;

            Assert.True(z.IsError);
            Assert.False(z.IsSuccess);
        }

        [Fact]
        public void Linq_Select_IsSupported()
        {
            var some = Option.Some(3);

            var z = from i in some
                select i + 1;

            Assert.True(z.IsSome);
            Assert.False(z.IsNone);
        }
    }
}