namespace Kata.Tests
{

    using NUnit.Framework;

    [TestFixture]
    public class FriendOrFoeTests
    {
        [Test]
        public void FriendOrFoeTest()
        {
            string[] expected = { "Ryan", "Mark" };
            string[] names = { "Ryan", "Kieran", "Mark", "Jimmy" };
            CollectionAssert.AreEqual(expected, Friend.FriendOrFoe(names));
        }

        [Test]
        public void FriendOrFoeTestWithMoreNames()
        {
            string[] expected = { "John", "Adam" };
            string[] names = { "John", "Scott", "Adam", "Sandra" };
            CollectionAssert.AreEqual(expected, Friend.FriendOrFoe(names));
        }
    }
}