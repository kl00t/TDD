namespace CouponCode.Tests
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class CouponCodeTests
    {
        /**
         Your online store likes to give out coupons for special occasions.
        Some customers try to cheat the system by entering invalid codes or using expired coupons.

        Your mission: 
        Write a function called checkCoupon to verify that a coupon is valid and not expired.
        If the coupon is good, return true. Otherwise, return false.

        A coupon expires at the END of the expiration date. All dates will be passed in as strings in this format: "June 15, 2014"
         **/

        /// <summary>
        /// Valids the coupon.
        /// </summary>
        [Test]
        public static void ValidCoupon()
        {
            Assert.AreEqual(true, CouponCode.CheckCoupon("123", "123", "September 5, 2014", "October 1, 2014"));
        }

        /// <summary>
        /// Invalids the coupon.
        /// </summary>
        [Test]
        public static void InvalidCoupon()
        {
            Assert.AreEqual(false, CouponCode.CheckCoupon("123a", "123", "September 5, 2014", "October 1, 2014"));
        }

        /// <summary>
        /// Parses the string date correctly.
        /// </summary>
        [Test]
        [TestCase("September 5, 2014", 2014, 9, 5)]
        [TestCase("October 1, 2014", 2014, 10, 1)]
        public static void ParseStringDateCorrectly(string dateString, int year, int month, int day)
        {
            Assert.AreEqual(new DateTime(year, month, day), CouponCode.ParseDateString(dateString));
        }

        /// <summary>
        /// Parses the date string throws format exception.
        /// </summary>
        [Test]
        [ExpectedException(typeof(FormatException))]
        public static void ParseDateStringThrowsFormatException()
        {
            CouponCode.ParseDateString(string.Empty);
        }

        /// <summary>
        /// Determines whether [is matching code] [the specified entered code].
        /// </summary>
        /// <param name="enteredCode">The entered code.</param>
        /// <param name="correctCode">The correct code.</param>
        /// <param name="expectedResult">if set to <c>true</c> [expected result].</param>
        [Test]
        [TestCase("123", "123", true)]
        [TestCase("123a", "123", false)]
        public static void IsMatchingCode(string enteredCode, string correctCode, bool expectedResult)
        {
            Assert.AreEqual(expectedResult, CouponCode.IsMatchingCode(enteredCode, correctCode));
        }

        /// <summary>
        /// Determines whether [is valid date] [the specified expiration date].
        /// </summary>
        /// <param name="year">The year.</param>
        /// <param name="month">The month.</param>
        /// <param name="day">The day.</param>
        /// <param name="expectedResult">If set to <c>true</c> [expected result].</param>
        [Test]
        [TestCase(2014, 9, 5, false)]
        [TestCase(2020, 10, 1, true)]
        public static void IsValidDate(int year, int month, int day, bool expectedResult)
        {
            Assert.AreEqual(expectedResult, CouponCode.IsValidDate(DateTime.Today, new DateTime(year, month, day)));
        }

        [Test]
        public static void LastDayOfValidity()
        {
            Assert.IsTrue(CouponCode.IsValidDate(DateTime.Today, DateTime.Today));
        }
    }
}