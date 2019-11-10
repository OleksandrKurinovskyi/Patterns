using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Iterator.Iterators;

namespace Iterator.Iterators
{
    class IteratorForConcreteAggregate1<T> : IIterator<T>
    {
        private T[] _aggregate;

        public IteratorForConcreteAggregate1(T[] aggregate)
        {
            _aggregate = aggregate;
        }

        int pos = -1;

        public bool IsDone()
        {
            return ++pos < _aggregate.Length;
        }

        public T Current()
        {
            return _aggregate[pos];
        }

        public void Reset()
        {
            pos = -1;
        }

        public T First()
        {
            if (_aggregate.Length > 1)
            {
                return _aggregate[0];
            }
            else
            {
                throw new ArgumentException();
            }
        }
    }
}
