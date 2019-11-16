using System;
using System.Collections.Generic;
using Iterator.Iterators;
using Iterator.Aggregates;

namespace Iterator.Aggregates
{
    class ConcreteAggregate2<T> : IAggregate<T> where T : MenuItem, new()
    {
        private List<T> _aggregate;

        public ConcreteAggregate2()
        {
            _aggregate = new List<T>();
            AddMenuItem("List_Item1", "List_Item1", false, 100);
            AddMenuItem("List_Item2", "List_Item2", false, 100);
            AddMenuItem("List_Item3", "List_Item3", false, 100);

        }

        private void AddMenuItem(string name, string description, bool isVegin, float price)
        {
            T menuItem = new T();
            _aggregate.Add(menuItem);
            menuItem.Init(name, description, isVegin, price);
        }

        public IIterator<T> GetIterator()
        {
            return new IteratorForConcreteAggregate2<T>(_aggregate);
        }
    }
}
