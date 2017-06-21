namespace Kata
{
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// 
    /// </summary>
    public class Friend
    {
        /// <summary>
        /// Friends the or foe.
        /// </summary>
        /// <param name="names">The names.</param>
        /// <returns></returns>
        public static IEnumerable<string> FriendOrFoe(string[] names)
        {
            return names.Where(name => name.Length == 4).AsEnumerable();
        }
    }
}
