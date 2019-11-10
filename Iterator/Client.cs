using System;
using Iterator.Aggregates;
using Iterator.Iterators;

namespace Iterator
{
    class Client
    {
        public void Print<T>(IAggregate<T> aggregate) where T : MenuItem
        {
            Console.WriteLine(new string('_', 20));
            var iterator = aggregate.GetIterator();
            while (iterator.IsDone())
            {
                Console.WriteLine(iterator.Current());
            }
            Console.WriteLine(new string('_', 20));
        }
    }
}
