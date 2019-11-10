using System;
using Iterator.Iterators;

namespace Iterator.Aggregates
{
    class ConcreteAggregate1<T> : IAggregate<T> where T : MenuItem, new()
    {
        private static readonly int MaxSize = 2;

        private T[] _aggregate;

        public ConcreteAggregate1()
        {
            _aggregate = new T[MaxSize];
            AddMenuItem("Array_Item1", "Array_Item1", false, 100);
            AddMenuItem("Array_Item2", "Array_Item2", false, 100);
            AddMenuItem("Array_`Item3", "Array_Item3", false, 100);

        }

        private void AddMenuItem(string name, string description, bool isVegin, float price)
        {
            int emptyIndex = Array.IndexOf(_aggregate, null);
            if (emptyIndex >= 0)
            {
                T menuItem = new T();
                _aggregate[emptyIndex] = menuItem;
                menuItem.Init(name, description, isVegin, price);

            }
            else
            {
                Console.WriteLine("Can not add");
            }
        }

        public IIterator<T> GetIterator()
        {
            return new IteratorForConcreteAggregate1<T>(_aggregate);
        }
    }
}
