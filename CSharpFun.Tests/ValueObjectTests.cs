using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Xunit;
using Xunit.Abstractions;

namespace CSharpFun.Tests
{
    public class ValueObjectTests
    {
        private readonly ITestOutputHelper _testOutputHelper;

        public ValueObjectTests(ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;
        }

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

        [Fact]
        public void GenericValueObject_Second_Comparison_Is_Much_Faster()
        {
            var max = new PersonName("Max", "Meier");
            var fritz = new PersonName("Fritz", "Müller");

            var comparisons = Enumerable.Range(1, 10)
                .Select(idx => new Action(() => { var _ = max == fritz; }))
                .ToArray();

            var timingPoints = Measure(comparisons).ToArray();

            OutputMeasureResult(timingPoints, _testOutputHelper.WriteLine);

            var diffs = timingPoints;

            Assert.True(diffs[1] * 2 < diffs[0], (diffs[0] - diffs[1]).ToString());
            Assert.True(diffs[2] * 10 < diffs[1]);
        }

        private static IEnumerable<TimeSpan> Measure(params Action[] actions)
        {
            if (actions == null || actions.Length == 0)
                yield break;

            var watch = Stopwatch.StartNew();

            actions[0]();

            yield return watch.Elapsed;

            if (actions.Length == 1)
                yield break;

            var previous = watch.Elapsed;

            foreach (var action in actions.Skip(1))
            {
                action();

                yield return watch.Elapsed - previous;

                previous = watch.Elapsed;
            }

            watch.Stop();
        }

        private static void OutputMeasureResult(IEnumerable<TimeSpan> times, Action<string> writeMessage)
        {
            var timings = times.Select((time, idx) => $"Time{idx + 1:D2} {time} ({(idx == 0 ? " " : "+")}{time.Milliseconds:D3}ms)");

            writeMessage(string.Join("\n", timings));
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

            public string Firstname { get; }

            public string Lastname { get; }
        }
    }
}