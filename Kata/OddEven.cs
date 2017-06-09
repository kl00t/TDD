namespace Kata
{
    /// <summary>
    /// Create a function that takes an integer as an argument and returns "Even" for even numbers or "Odd" for odd numbers.
    /// </summary>
    public class OddEven
    {
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