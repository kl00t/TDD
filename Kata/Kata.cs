namespace Kata
{
    using System.Collections.Generic;
    using System.Linq;

    public static class Kata
    {
        /// <summary>
        /// Makes the upper case.
        /// </summary>
        /// <param name="str">The string.</param>
        /// <returns>Returns the string input as uppercase string.</returns>
        public static string MakeUpperCase(string str)
        {
            return str.ToUpper();
        }

        /// <summary>
        /// Bonuses the time.
        /// </summary>
        /// <param name="salary">The salary.</param>
        /// <param name="bonus">if set to <c>true</c> [bonus].</param>
        /// <returns>Returns the bonus.</returns>
        public static string BonusTime(int salary, bool bonus)
        {
            return bonus ? $"${salary*10}" : $"${salary}";
        }

        /// <summary>
        /// Friends the or foe.
        /// </summary>
        /// <param name="names">The names.</param>
        /// <returns>Returns the names.</returns>
        public static IEnumerable<string> FriendOrFoe(string[] names)
        {
            return names.Where(name => name.Length == 4).AsEnumerable();
        }

        /// <summary>
        /// The even string.
        /// </summary>
        private const string Even = "Even";

        /// <summary>
        /// The odd string.
        /// </summary>
        private const string Odd = "Odd";

        /// <summary>
        /// Evens the or odd.
        /// </summary>
        /// <param name="number">The number.</param>
        /// <returns>
        /// Returns either "Odd" or "Even" for a given integer.
        /// </returns>
        public static string EvenOrOdd(int number)
        {
            return number % 2 != 0 ? Odd : Even;
        }
    }
}