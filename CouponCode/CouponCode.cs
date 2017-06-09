namespace CouponCode
{
    using System;

    public static class CouponCode
    {
        /// <summary>
        /// Checks the coupon.
        /// </summary>
        /// <param name="enteredCode">The entered code.</param>
        /// <param name="correctCode">The correct code.</param>
        /// <param name="currentDate">The current date.</param>
        /// <param name="expirationDate">The expiration date.</param>
        /// <returns>
        /// Returns whether a coupon is valid or not.
        /// </returns>
        public static bool CheckCoupon(string enteredCode, string correctCode, string currentDate, string expirationDate)
        {
            return IsMatchingCode(enteredCode, correctCode) 
                && IsValidDate(ParseDateString(currentDate), ParseDateString(expirationDate));
        }

        /// <summary>
        /// Determines whether [is matching code] [the specified entered code].
        /// </summary>
        /// <param name="enteredCode">The entered code.</param>
        /// <param name="correctCode">The correct code.</param>
        /// <returns>
        ///   <c>true</c> if [is matching code] [the specified entered code]; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsMatchingCode(string enteredCode, string correctCode)
        {
            return enteredCode.Equals(correctCode);
        }

        /// <summary>
        /// Determines whether [is valid date] [the specified expiration date].
        /// </summary>
        /// <param name="currentDate"></param>
        /// <param name="expirationDate">The expiration date.</param>
        /// <returns>
        ///   <c>true</c> if [is valid date] [the specified expiration date]; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsValidDate(DateTime currentDate, DateTime expirationDate)
        {
            return currentDate <= expirationDate;
        }

        /// <summary>
        /// Parses the date string.
        /// </summary>
        /// <param name="dateString">The date string.</param>
        /// <returns>Returns a new date time from a string.</returns>
        public static DateTime ParseDateString(string dateString)
        {
            return DateTime.Parse(dateString);
        }
    }
}