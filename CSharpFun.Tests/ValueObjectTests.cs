using System;
using Xunit;

namespace CSharpFun.Tests
{
    public class ValueObjectTests
    {
        [Fact]
        public void Comparison_Is_Done_By_Values()
        {
            var email1 = new Email("donald@duckburg.com");
            var email2 = new Email("donald@duckburg.com");

            Assert.Equal(email1, email2);
        }

        [Fact]
        public void GenericValueObject_Comparison_Is_Done_By_Values()
        {
            var max = new PersonName("Max", "Meier");
            var max2 = new PersonName("Max", "Meier");

            Assert.Equal(max2, max);
        }

        private class Email : SingleValueObject<string>
        {
            public Email(string value) : base(value)
            {
                if(!value?.Contains("@") ?? false)
                    throw new ArgumentException("No valid E-Mail address.");
            }
        }

        private class PersonName : ValueObject
        {
            public PersonName(string firstname, string lastname)
            {
                Firstname = firstname;
                Lastname = lastname;
            }

            // ReSharper disable once MemberCanBePrivate.Local
            // ReSharper disable once UnusedAutoPropertyAccessor.Local
            public string Firstname { get; }

            // ReSharper disable once MemberCanBePrivate.Local
            // ReSharper disable once UnusedAutoPropertyAccessor.Local
            public string Lastname { get; }
        }
    }
}