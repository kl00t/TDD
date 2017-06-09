namespace Kata.Tests
{
    using NUnit.Framework;

    [TestFixture]
    public class OddEvenTests
    {
        /// <summary>
        /// Mies the test.
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
            Assert.AreEqual(expectedResult, OddEven.EvenOrOdd(number));
        }
    }
}
