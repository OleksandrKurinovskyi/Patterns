namespace Iterator.Iterators
{
    interface IIterator<T>
    {
        bool IsDone();

        T Current();

        void Reset();

        T First();
    }
}
