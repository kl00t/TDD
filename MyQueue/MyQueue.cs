namespace MyQueue
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// This is a queue that holds 5 integers.
    /// </summary>
    public class MyQueue : MyQueueBase, IMyQueue
    {
        public MyQueue()
        {
            Values = new List<int>();
        }

        public const int MaximumNumberOfQueueItems = 100;

        public const int MaximumIntegerValue = 99;

        public List<int> Values { get; set; }

        public int Count
        {
            get
            {
                return Values.Count;
            }
        }

        public void Add(int newIntegerValue)
        {
            if (!MaximumQueueLimitReached() && IsPositiveInteger(newIntegerValue) && !IsMaximumIntegerValue(newIntegerValue))
            {
                Values.Add(newIntegerValue);
            }
        }

        private bool IsMaximumIntegerValue(int value)
        {
            if (value > MaximumIntegerValue)
            {
                throw new ArgumentOutOfRangeException();
            }

            return false;
        }

        public int GetValue(int position)
        {
            return Values[position];
        }

        public void Remove(int position)
        {
            Values.RemoveAt(position);
        }

        private bool MaximumQueueLimitReached()
        {
            if (Values.Count >= MaximumNumberOfQueueItems)
            {
                throw new ArgumentException(string.Format("Maximum number of queue items reached: {0}", MaximumNumberOfQueueItems));
            }

            return false;
        }
    }
}