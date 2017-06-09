namespace Money.Tests
{
    using NUnit.Framework;

    [TestFixture]
    public class MoneyTests
    {
        [Test]
        public void testMultiplication()
        {
            var five = Money.dollar(5);
            Assert.AreEqual(Money.dollar(10), five.Times(2));
            Assert.AreEqual(Money.dollar(15), five.Times(3));
        }

        [Test]
        public void testEquality()
        {
            Assert.IsTrue(Money.dollar(5).Equals(Money.dollar(5)));
            Assert.IsFalse(Money.dollar(5).Equals(Money.dollar(6)));
            Assert.IsFalse(Money.franc(5).Equals(Money.dollar(5)));
        }

        [Test]
        public void testCurrency()
        {
            Assert.AreEqual("USD", Money.dollar(1).Currency());
            Assert.AreEqual("CHF", Money.franc(1).Currency());
        }

        [Test]
        public void testSimpleAddition()
        {
            Money five = Money.dollar(5);
            Expression sum = five.plus(five);
            Bank bank = new Bank();
            var reduced = bank.reduce(sum, "USD");
            Assert.AreEqual(Money.dollar(10), reduced);
        }

        [Test]
        public void testPlusReturnsSum()
        {
            Money five = Money.dollar(5);
            Expression result = five.plus(five);
            var sum = (Sum)result;
            Assert.AreEqual(five, sum.augend);
            Assert.AreEqual(five, sum.addend);
        }

        [Test]
        public void testReduceSum()
        {
            Expression sum  = new Sum(Money.dollar(3), Money.dollar(4));
            Bank bank = new Bank();
            Money result = bank.reduce(sum, "USD");
            Assert.AreEqual(Money.dollar(7), result);
        }

        [Test]
        public void testReduceMoney()
        {
            Bank bank = new Bank();
            Money result = bank.reduce(Money.dollar(1), "USD");
            Assert.AreEqual(Money.dollar(1), result);
        }

        [Test]
        public void testReduceMoneyDifferentCurrency()
        {
            Bank bank = new Bank();
            bank.addRate("CHF", "USD", 2);
            Money result = bank.reduce(Money.franc(2), "USD");
            Assert.AreEqual(Money.dollar(1), result);
        }

        [Test]
        public void testArrayEquals()
        {
            Assert.AreEqual(new object[] { "abc"}, new object[] { "abc" });
        }

        [Test]
        public void testIdentityRate()
        {
            Assert.AreEqual(1, new Bank().rate("USD", "USD"));
        }

        [Test]
        public void testMixedAddition()
        {
            Expression fiveBucks = Money.dollar(5);
            Expression tenFrancs = Money.franc(10);
            Bank bank = new Bank();
            bank.addRate("CHF", "USD", 2);
            Money result = bank.reduce(fiveBucks.plus(tenFrancs), "USD");
            Assert.AreEqual(Money.dollar(10), result);
        }

        [Test]
        public void testSumPlusMoney()
        {
            Expression fiveBucks = Money.dollar(5);
            Expression tenFrancs = Money.franc(10);
            Bank bank = new Bank();
            bank.addRate("CHF", "USD", 2);
            Expression sum = new Sum(fiveBucks, tenFrancs).plus(fiveBucks);
            Money result = bank.reduce(sum, "USD");
            Assert.AreEqual(Money.dollar(15), result);
        }

        [Test]
        public void testSumTimes()
        {
            Expression fiveBucks = Money.dollar(5);
            Expression tenFrancs = Money.franc(10);
            Bank bank = new Bank();
            bank.addRate("CHF", "USD", 2);
            Expression sum = new Sum(fiveBucks, tenFrancs).times(2);
            Money result = bank.reduce(sum, "USD");
            Assert.AreEqual(Money.dollar(20), result);
        }

        [Test]
        [Ignore]
        public void testPlusSameCurrencyReturnsMoney()
        {
            Expression sum = Money.dollar(1).plus(Money.dollar(1));
            Assert.IsInstanceOf<Money>(sum);
        }
    }
}
