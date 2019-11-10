using Iterator.Iterators;

namespace Iterator.Aggregates
{
    interface IAggregate<T>
    {
        IIterator<T> GetIterator();
    }
}
