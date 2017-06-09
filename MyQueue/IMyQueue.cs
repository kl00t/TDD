namespace MyQueue
{
    public interface IMyQueue
    {
        void Add(int value);

        void Remove(int value);

        int GetValue(int position);
    }
}