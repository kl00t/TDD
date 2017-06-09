namespace MyQueue
{
    using System;

    public class MyQueueBase
    {
        protected bool IsPositiveInteger(int value)
        {
            if (value >= 0)
            {
                return true;
            }

            throw new ArgumentOutOfRangeException();
        }
    }
}