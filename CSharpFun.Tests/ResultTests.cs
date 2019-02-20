using System;
using Xunit;

namespace CSharpFun.Tests
{
    public class ResultTests
    {
        [Fact]
        public void New_SuccessResult_WithNullValue_Throws()
        {
            Assert.Throws<ArgumentNullException>(() => new SuccessResult<string>(null));
        }

        [Fact]
        public void New_ErrorResult_WithNullValue_Throws()
        {
            Assert.Throws<ArgumentNullException>(() => new ErrorResult<string>(null));
        }

        [Fact]
        public void IsSuccess_OnDefaultResult_WillBeFalse()
        {
            Result<int, string> result = default;

            Assert.False(result.IsSuccess);
        }

        [Fact]
        public void IsError_OnDefaultResult_WillBeFalse()
        {
            Result<int, string> result = default;

            Assert.False(result.IsError);
        }

        [Fact]
        public void IsSuccess_OnSuccessResult_IsTrue()
        {
            var result = Result<int, bool>.Success(3);

            Assert.True(result.IsSuccess);
            Assert.False(result.IsError);
        }

        [Fact]
        public void Casting_From_NotInitialized_SuccessResult_Does_Not_Throw()
        {
            Assert.Throws<ArgumentNullException>(() => Result<string, bool>.Success(null));

            SuccessResult<string> uninitialized = default;

            Result<string, bool> _ = uninitialized;
        }

        [Fact]
        public void IsError_OnErrorResult__IsTrue()
        {
            var result = Result<bool, int>.Error(3);

            Assert.True(result.IsError);
            Assert.False(result.IsSuccess);
        }

        [Fact]
        public void Error_Can_NotBe_Null()
        {
            Assert.Throws<ArgumentNullException>(() => Result<bool, string>.Error(null));
        }

        [Fact]
        public void Match_OnDefaultResult_WillThrow()
        {
            Result<int, string> result = default;

            Assert.Throws<InvalidOperationException>(() => result.Match(_ => true, _ => true));
        }

        [Fact]
        public void Match_WhenIsSuccess_CallsOnSuccess()
        {
            var result = Result<int, bool>.Success(5);

            var actual = result.Match(value => value, _ => 0);

            Assert.Equal(5, actual);
        }

        [Fact]
        public void Match_WhenIsError_CallsOnError()
        {
            var result = Result<int, bool>.Error(false);

            var actual = result.Match(_ => 0, _ => 5);

            Assert.Equal(5, actual);
        }

        public class Conversion
        {
            [Fact]
            public void Can_Implicitly_Convert_From_SuccessResult()
            {
                var success = new SuccessResult<int>(5);

                Result<int, bool> result = success;

                Assert.True(result.IsSuccess);
            }

            [Fact]
            public void Can_Implicitly_Convert_From_DefaultSuccessResult()
            {
                SuccessResult<string> uninitialized = default;
                Result<string, bool> _ = uninitialized;
            }

            [Fact]
            public void Can_Implicitly_Convert_From_ErrorResult()
            {
                var failure = new ErrorResult<int>(5);

                Result<bool, int> result = failure;

                Assert.True(result.IsError);
            }

            [Fact]
            public void Can_Implicitly_Convert_From_DefaultErrorResult()
            {
                ErrorResult<string> uninitialized = default;
                Result<bool, string> _ = uninitialized;
            }
        }

        public class Comparison
        {
            [Fact]
            public void Can_Compare_Result_With_SuccessResult()
            {
                var successResult = Result.Success("Test");
                var result = Result<string, bool>.Success("Test");

                Assert.True(result == successResult);
                Assert.True(successResult == result);
            }

            [Fact]
            public void Can_Compare_Result_With_ErrorResult()
            {
                var failureResult = Result.Error("Test");
                var result = Result<bool, string>.Error("Test");

                Assert.True(result == failureResult);
                Assert.True(failureResult == result);
            }
        }
}