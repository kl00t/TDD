namespace MyQueue.Tests
{
    using System;
    using System.Collections.Generic;
    using NUnit.Framework;

    /// <summary>
    /// My Queue Test fixture class.
    /// </summary>
    [TestFixture]
    public class MyQueueTest
    {
        /// <summary>
        /// Private variable My queue.
        /// </summary>
        private MyQueue _myQueue;

        /// <summary>
        /// Setups this instance.
        /// </summary>
        [SetUp]
        public void Setup()
        {
            _myQueue = new MyQueue();
        }

        /// <summary>
        /// Verifies the that my queue can be created.
        /// </summary>
        [Test]
        public void VerifyThatMyQueueCanBeCreated()
        {
            Assert.IsInstanceOf<MyQueue>(_myQueue);
        }

        /// <summary>
        /// Verifies the that my queue is empty when created.
        /// </summary>
        [Test]
        public void VerifyThatMyQueueIsEmptyWhenCreated()
        {
            Assert.IsEmpty(_myQueue.Values);
        }

        /// <summary>
        /// Verifies the that integer values can be put onto the queue.
        /// </summary>
        [Test]
        public void VerifyThatIntegerValuesCanBePutOntoTheQueue()
        {
            AddTestValues(new List<int> { 1, 2, 3 });
            Assert.AreEqual(3, _myQueue.Count);
        }

        [Test]
        public void VerifyThatTheValueCanBeObtained()
        {
            AddTestValues(new List<int> { 1, 2, 3 });
            Assert.AreEqual(2, _myQueue.GetValue(1));
        }

        [Test]
        public void VerifyTheNumberOfElementsThatQueueContains()
        {
            AddTestValues(new List<int> { 1, 2, 3 });
            Assert.AreEqual(3, _myQueue.Count);
        }

        [Test]
        public void VerifyThatAnElementCanBeRemovedFromTheQueue()
        {
            AddTestValues(new List<int> { 1, 2, 3 });
            _myQueue.Remove(1);
            Assert.AreEqual(2, _myQueue.Count);
        }

        [Test]
        public void VerifyThatTheQueueSupports100Integers()
        {
            for (var i = 0; i < 100; i++)
            {
                _myQueue.Add(i);
            }

            Assert.AreEqual(100, _myQueue.Count);
        }

        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void VerifyThatTheQueueDoesNotSupportOver100Integers()
        {
            for (var i = 0; i < 101; i++)
            {
                
                _myQueue.Add(i);
            }
        }

        [Test]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void VerifyThatAnArgumentOutOfRangeExceptionIsThrownIfNegativeNumberIsUsed()
        {
            _myQueue.Add(-1);
        }

        [Test]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void VerifyThatAnArgumentOutOfRangeExceptionIsThrownIfNumberLargerThan99IsUsed()
        {
            _myQueue.Add(100);
        }

        private void AddTestValues(IEnumerable<int> values)
        {
            foreach (var value in values)
            {
                _myQueue.Add(value);
            }
        }
    }
}