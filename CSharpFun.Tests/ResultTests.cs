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

        public class Validation
        {
            [Fact]
            public void CanCombineMultipleResultsAndGetCombinedErrors()
            {
                //var d = (1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25);
                //var (d1, d2, d3, d4, d5, d6, d7, d8, d9, d10, d11, d12, d13, d14, d15, d16, d17, d18, d19, d20, d21, d22, d23, d24, d25) = d;

                var res1 = Result<string, string>.Success("Case1");
                var res2 = Result<int, string>.Error("Time 2 panic!!");
                var res3 = Result<bool, string>.Error("It's so simple: it did not work.");

                var res = Result.Combine(res1, res2, res3);

                Assert.True(res.IsError);

                var errors = res.GetErrorOrThrow();

                Assert.Equal(2, errors.Count);
                Assert.Equal("Time 2 panic!!", errors[0]);
                Assert.Equal("It's so simple: it did not work.", errors[1]);
            }

            [Fact]
            public void CanCombineMultipleResultsAndGetCombinedValues()
            {
                var res1 = Result<string, string>.Success("Case1");
                var res2 = Result<int, string>.Success(5);
                var res3 = Result<bool, string>.Success(true);

                var res = Result
                    .Combine(res1, res2, res3)
                    .Map((s, i, b) => s+i+b);

                Assert.True(res.IsSuccess);

                var value = res.GetValueOrThrow();

                Assert.Equal("Case15True", value);
            }

            [Fact]
            public void Equality_WithUnderlyingType_ComparesValues()
            {
                var result = Result<string, string>.Success("Test");

                Assert.True(result == "Test");
                Assert.True("Test" == result);

                Assert.False(result != "Test");
                Assert.False("Test" != result);

                Assert.False(result == "Test1");
                Assert.False("Test1" == result);

                Assert.True(result != "Test1");
                Assert.True("Test1" != result);

                Assert.False(result == null);
                Assert.True(result != null);

                Assert.True(result.Equals("Test"));
                Assert.False(result.Equals(null));
            }
        }
    }
}