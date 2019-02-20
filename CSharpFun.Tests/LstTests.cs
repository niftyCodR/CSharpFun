using System;
using System.Linq;
using Xunit;

namespace CSharpFun.Tests
{
    public class LstTests
    {
        [Fact]
        public void WhenCreatedWithoutItems_IsEmpty_IsTrue()
        {
            var sut = new Lst<string>();

            Assert.True(sut.IsEmpty);
        }

        [Fact]
        public void WhenCreatedWithItems_IsEmpty_IsFalse()
        {
            var sut = new Lst<string>("Item1", "Item2");

            Assert.False(sut.IsEmpty);
        }

        [Fact]
        public void CanIterate_Over_Items()
        {
            var sut = new Lst<string>("Item1", "Item2");

            var items = sut.ToList();

            Assert.Equal(2, items.Count);
            Assert.Equal("Item1", items[0]);
            Assert.Equal("Item2", items[1]);
        }

        [Fact]
        public void Count_Returns_NumberOfItems()
        {
            var sut = new Lst<string>("Item1", "Item2", "Err3");

            Assert.Equal(3, sut.Count);
        }

        [Fact]
        public void Index_Returns_Items()
        {
            var sut = new Lst<string>("Item1", "Item2", "Err3");

            Assert.Equal("Item1", sut[0]);
            Assert.Equal("Item2", sut[1]);
            Assert.Equal("Err3", sut[2]);
        }

        [Fact]
        public void Index_WhenIndexGreaterThanNumberOfElementsMinusOne_Throws()
        {
            var sut = new Lst<string>("Item1", "Item2");

            Assert.Throws<ArgumentOutOfRangeException>(() => sut[2]);
        }

        [Fact]
        public void Index_WhenIndexIsLessThanZero_Throws()
        {
            var sut = new Lst<string>("Item1", "Item2");

            Assert.Throws<ArgumentOutOfRangeException>(() => sut[-1]);
        }

        [Fact]
        public void Index_WhenIndexIsZeroAndItemsIsEmpty_Throws()
        {
            var sut = new Lst<string>();

            Assert.Throws<ArgumentOutOfRangeException>(() => sut[0]);
        }

        [Fact]
        public void Can_Add_Two_Lists()
        {
            var sut1 = new Lst<string>("Item1", "Item2", "Item3");
            var sut2 = new Lst<string>("Item4", "Item5");

            var actual = sut1 + sut2;

            Assert.Equal(5, actual.Count);
            Assert.Equal("Item1", actual[0]);
            Assert.Equal("Item2", actual[1]);
            Assert.Equal("Item3", actual[2]);
            Assert.Equal("Item4", actual[3]);
            Assert.Equal("Item5", actual[4]);
        }
    }
}