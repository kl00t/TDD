namespace Kata.Tests
{
    using NUnit.Framework;

    [TestFixture]
    public class KataTests
    {
        [Test]
        public void BonusTimeTest()
        {
            StringAssert.AreEqualIgnoringCase("$100000", Kata.BonusTime(10000, true));
            StringAssert.AreEqualIgnoringCase("$250000", Kata.BonusTime(25000, true));
            StringAssert.AreEqualIgnoringCase("$10000", Kata.BonusTime(10000, false));
            StringAssert.AreEqualIgnoringCase("$60000", Kata.BonusTime(60000, false));
            StringAssert.AreEqualIgnoringCase("$20", Kata.BonusTime(2, true));
            StringAssert.AreEqualIgnoringCase("$78", Kata.BonusTime(78, false));
            StringAssert.AreEqualIgnoringCase("$678900", Kata.BonusTime(67890, true));
        }

        [Test]
        public void MakeUpperCaseTest()
        {
            Assert.AreEqual("HELLO", Kata.MakeUpperCase("hello"));
        }

        [Test]
        public void FriendOrFoeTest()
        {
            string[] expected = { "Ryan", "Mark" };
            string[] names = { "Ryan", "Kieran", "Mark", "Jimmy" };
            CollectionAssert.AreEqual(expected, Kata.FriendOrFoe(names));
        }

        [Test]
        public void FriendOrFoeTestWithMoreNames()
        {
            string[] expected = { "John", "Adam" };
            string[] names = { "John", "Scott", "Adam", "Sandra" };
            CollectionAssert.AreEqual(expected, Kata.FriendOrFoe(names));
        }

        /// <summary>
        /// My test.
        /// </summary>
        /// <param name="expectedResult">The expected result.</param>
        /// <param name="number">The number.</param>
        [Test]
        [TestCase("Even", 2)]
        [TestCase("Odd", 1)]
        [TestCase("Even", 0)]
        [TestCase("Odd", 7)]
        [TestCase("Even", -2)]
        [TestCase("Odd", -1)]
        [TestCase("Even", -0)]
        [TestCase("Odd", -7)]
        public void MyTest(string expectedResult, int number)
        {
            Assert.AreEqual(expectedResult, Kata.EvenOrOdd(number));
        }
    }
}