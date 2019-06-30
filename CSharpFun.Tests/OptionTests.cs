using System;
using Xunit;

namespace CSharpFun.Tests
{
    public class OptionTests
    {
        [Fact]
        public void DefaultOption_Is_Considered_None()
        {
            Option<string> option = default;

            Assert.Equal(option, Option.None);

            Option<string> option2 = new NoneOption();

            Assert.Equal(option2, Option.None);
        }

        [Fact]
        public void NoneOption_IsSome_IsFalse()
        {
            Option<string> option = Option.None;

            Assert.False(option.IsSome);
        }

        [Fact]
        public void NoneOption_IsNone_IsTrue()
        {
            Option<string> option = Option.None;

            Assert.True(option.IsNone);
        }

        [Fact]
        public void SomeOption_IsSome_IsTrue()
        {
            var option = Option.Some("Test");

            Assert.True(option.IsSome);
        }

        [Fact]
        public void SomeOption_IsNone_IsFalse()
        {
            var option = Option.Some("Test");

            Assert.False(option.IsNone);
        }

        [Fact]
        public void Some_WithNullValue_Throws()
        {
            Assert.Throws<ArgumentNullException>(() => Option.Some<string>(null));
        }

        [Fact]
        public void SomeOrNoneWhenNull_WithNullValue_Is_Considered_None()
        {
            var option = Option.SomeOrNoneWhenNull<string>(null);

            Assert.True(option.IsNone);
            Assert.False(option.IsSome);
        }

        [Fact]
        public void Two_Options_With_Same_Value_Are_Considered_Equal()
        {
            var option1 = Option.Some("Test");
            var option2 = Option.Some("Test");

            Assert.True(option1.Equals(option2));
            Assert.True(option1.Equals((object)option2));
            Assert.True(option1 == option2);
            Assert.False(option1 != option2);
        }

        [Fact]
        public void Two_Options_With_Different_Values_Are_Considered_NotEqual()
        {
            var option1 = Option.Some("Test");
            var option2 = Option.Some("Test2");

            Assert.False(option1.Equals(option2));
            Assert.False(option1.Equals((object)option2));
            Assert.False(option1 == option2);
            Assert.True(option1 != option2);
        }

        [Fact]
        public void NonOption_Can_Be_Compared_With_Option()
        {
            var some = Option.Some("Test");
            var none = Option.None;

            Assert.False(some == none);
            Assert.True(some != none);
            Assert.False(none == some);
            Assert.True(none != some);
        }

        [Fact]
        public void Match_With_Some_Value_Calls_Some_Func()
        {
            var option = Option.Some(3);

            var res = option.Match(val => val, () => 0);

            Assert.Equal(3, res);
        }

        [Fact]
        public void Match_With_None_Value_Calls_Nome_Func()
        {
            Option<int> option = Option.None;

            var res = option.Match(val => val, () => 3);

            Assert.Equal(3, res);
        }

        [Fact]
        public void Match_WhenCalledWithNull_ThrowsException()
        {
            var option = Option.Some(3);

            Assert.Throws<ArgumentNullException>(() => option.Match(null, () => 3));
            Assert.Throws<ArgumentNullException>(() => option.Match(val => val, null));
        }

        [Fact]
        public void Map_WhenCalledWithNull_ThrowsException()
        {
            var option = Option.Some(3);

            Assert.Throws<ArgumentNullException>(() => option.Map<int, string>(null));
        }

        [Fact]
        public void Map_FromNone_ReturnsNone()
        {
            Option<string> option = Option.None;

            var actual = option.Map(val => val);

            Assert.True(actual.IsNone);
            Assert.False(actual.IsSome);
        }

        [Fact]
        public void Map_FromSome_ReturnsSomeWithMappedValue()
        {
            Option<string> option = Option.Some("Test");

            var actual = option.Map(val => "Test2");

            var value = actual.Match(val => val, () => "Err");

            Assert.True(actual.IsSome);
            Assert.False(actual.IsNone);

            Assert.Equal("Test2", value);
        }

        [Fact]
        public void Bind_WhenCalledWithNull_ThrowsException()
        {
            var option = Option.Some(3);

            Assert.Throws<ArgumentNullException>(() => option.Bind<int, string>(null));
        }

        [Fact]
        public void Bind_FromNone_ReturnsNone()
        {
            Option<string> option = Option.None;

            var actual = option.Bind(Option.Some);

            Assert.True(actual.IsNone);
            Assert.False(actual.IsSome);
        }

        [Fact]
        public void Bind_FromSome_ReturnsSomeTransformedOption()
        {
            var option = Option.Some("Test");

            var actual = option.Bind(val => Option.Some("Test2"));

            var value = actual.Match(val => val, () => "Err");

            Assert.True(actual.IsSome);
            Assert.False(actual.IsNone);

            Assert.Equal("Test2", value);
        }

        [Fact]
        public void Can_Deconstruct_Into_Tuple()
        {
            var option = Option.Some("Test");

            var (isSome, value) = option;

            Assert.True(isSome);
            Assert.Equal("Test", value);
        }
                
        [Fact]
        public void TryGetValue_Supports_Standard_Signature()
        {
            var option = Option.Some("Test");

            var isSome = option.TryGetValue(out var value);

            Assert.True(isSome);
            Assert.Equal("Test", value);
        }

        [Fact]
        public void Filter_ReturnsNone_On_NoneOption()
        {
            var option = Option<string>.None;

            var actual = option.Filter(value => true);

            Assert.True(actual.IsNone);
        }

        [Fact]
        public void Filter_ReturnsNone_On_SomeOption_WhenFilterReturnsFalse()
        {
            var option = Option<string>.Some("Test");

            var actual = option.Filter(value => false);

            Assert.True(actual.IsNone);
        }

        [Fact]
        public void Filter_ReturnsSome_On_SomeOption_WhenFilterReturnsTrue()
        {
            var option = Option<string>.Some("Test");

            var actual = option.Filter(value => true);

            Assert.True(actual.IsSome);
        }

        [Fact]
        public void Equality_WithUnderlyingType_ComparesValues()
        {
            var option = Option<string>.Some("Test");

            Assert.True(option == "Test");
            Assert.True("Test" == option);

            Assert.False(option != "Test");
            Assert.False("Test" != option);

            Assert.False(option == "Test1");
            Assert.False("Test1" == option);

            Assert.True(option != "Test1");
            Assert.True("Test1" != option);

            Assert.False(option == null);
            Assert.True(option != null);

            Assert.True(option.Equals("Test"));
            Assert.False(option.Equals(null));
        }
    }
}