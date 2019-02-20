using CSharpFun.Linq;
using Xunit;

namespace CSharpFun.Tests.Linq
{
    public class OptionLinqTests
    {
        [Fact]
        public void Linq_SelectMany_IsSupported()
        {
            var some = Option.Some(3);
            Option<int> none = Option.None;

            var z = from i in some
                from j in none
                select i + j;

            Assert.True(z.IsNone);
            Assert.False(z.IsSome);
        }

        [Fact]
        public void Linq_Select_IsSupported()
        {
            var some = Option.Some(3);

            var z = from i in some
                select i + 1;

            Assert.True(z.IsSome);
            Assert.False(z.IsNone);
            Assert.Equal(4, z.GetValueOrThrow());
        }

        [Fact]
        public void Linq_From_IsSupported()
        {
            var some = Option.Some(3);

            var z = from i in some
                where i > 5
                select i + 1;

            Assert.True(z.IsNone);
            Assert.False(z.IsSome);
        }
    }
}