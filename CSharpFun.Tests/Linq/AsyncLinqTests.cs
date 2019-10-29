using System.Threading.Tasks;
using CSharpFun.Linq;
using CSharpFun.Linq.Async;
using Xunit;

namespace CSharpFun.Tests.Linq
{
    public class AsyncLinqTests
    {
        [Fact]
        public async Task Single_Select_Result()
        {
            // This test just showcases how to deal with async results in a single select.
            // There is no code from this library involved.
            var result =
                from res1 in await AsyncSuccessResult(false)
                select res1;

            Assert.True(result.IsSuccess);
            Assert.False(result.GetValueOrThrow());
        }

        [Fact]
        public async Task Single_Select_Option()
        {
            // This test just showcases how to deal with async results in a single select.
            // There is no code from this library involved.
            var option =
                from res1 in await AsyncSomeOption(false)
                //where res1 == true // This would invert the option to IsNone
                select res1;

            Assert.True(option.IsSome);
            Assert.False(option.GetValueOrThrow());
        }

        [Fact]
        public async Task Combine_Multiple_Results()
        {
            var result = await (
                from res1 in AsyncSuccessResult(true)
                let b = res1
                from res2 in AsyncErrorResult(3)
                from res3 in SuccessResult(true).ToAsync()
                from res4 in ErrorResult(5).ToAsync()
                select res4
            );

            Assert.True(result.IsError);
            Assert.Equal(3, result.GetErrorOrThrow());
        }

        [Fact]
        public async Task Combine_Multiple_Options()
        {
            var option = await (
                from res1 in AsyncSomeOption(true)
                from res2 in AsyncSomeOption(false)
                //from res3 in Task.FromResult(Option<bool>.None) // This would invert the option to IsNone
                where !res2
                select res2
            );

            Assert.True(option.IsSome);
            Assert.False(option.GetValueOrThrow());
        }

        [Fact]
        public async Task Combine_Result_And_Option()
        {
            var result = await (
                    from res1 in AsyncSuccessResult(true)
                    from res2 in Option.Some(true).WithError(7).ToAsync()
                    from res3 in Task.FromResult(Option.Some(false)).WithError(6)
                    select res3
                    );

            Assert.True(result.IsSuccess);
            Assert.False(result.GetValueOrThrow());
        }

        private static async Task<Result<bool, int>> AsyncSuccessResult(bool value)
        {
            await Task.CompletedTask;

            return Result.Success(value);
        }

        private static async Task<Result<bool, int>> AsyncErrorResult(int error)
        {
            await Task.CompletedTask;

            return Result.Error(error);
        }

        private static Result<bool, int> SuccessResult(bool value) => Result.Success(value);

        private static Result<bool, int> ErrorResult(int error) => Result.Error(error);

        private static Task<Option<bool>> AsyncSomeOption(bool value) => Task.FromResult(Option.Some(value));
    }
}