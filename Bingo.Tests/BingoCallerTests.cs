namespace Bingo.Tests
{
    using NUnit.Framework;
    using System;
    using System.Linq;
    using System.Collections.Generic;

    [TestFixture]
    public class BingoCallerTests
    {
        [TestCase(1, "B1")]
        [TestCase(16, "I16")]
        [TestCase(31, "N31")]
        [TestCase(46, "G46")]
        [TestCase(61, "O61")]
        [TestCase(15, "B15")]
        [TestCase(30, "I30")]
        [TestCase(45, "N45")]
        [TestCase(60, "G60")]
        [TestCase(75, "O75")]
        [TestCase(8, "B8")]
        [TestCase(29, "I29")]
        [TestCase(44, "N44")]
        [TestCase(50, "G50")]
        [TestCase(72, "O72")]
        public void BingoCallerReturnsCorrectString(int number, string expected)
        {
            var sut = new BingoCaller(new FakeRandom(number));
            var actual = sut.GetNumber();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void EachNumberIsBetween1And75()
        {
            var caller = new BingoCaller(new Random());

            for (var i = 1; i <= 75; i++)
            {
                var number = caller.GetNumber();
                var n = Convert.ToInt32(number.Substring(1));
                Assert.LessOrEqual(1, n);
                Assert.GreaterOrEqual(75, n);
            }
        }

        [Test]
        public void RandomNumberGeneratorReturnsAllNumbersOnlyOnce()
        {
            var list = new List<string>();
            var sut = new BingoCaller(new Random());

            for (var i = 1; i <= 75; i++)
            {
                list.Add(sut.GetNumber());
            }

            Assert.AreEqual(list.Count, list.Distinct().Count());
        }

        [Test]
        public void RandomNumberGeneratorReturnsEmptyStringWhenAllNumbersAreCalled()
        {
            var sut = new BingoCaller(new Random());

            for (var i = 1; i <= 75; i++)
            {
                sut.GetNumber();
            }

            Assert.AreEqual("", sut.GetNumber());
        }
    }

    public class FakeRandom : Random
    {
        private int value;

        public FakeRandom(int values)
        {
            this.value = values;
        }

        public override int Next()
        {
            return value;
        }

        public override int Next(int maxValue)
        {
            return value;
        }

        public override int Next(int minValue, int maxValue)
        {
            return value;
        }
    }
}