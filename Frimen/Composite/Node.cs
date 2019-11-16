using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    abstract class Node : IComponent
    {
        public abstract void Option();

        public void Add(IComponent component)
        {
        }

        public void Remove(IComponent component)
        {
        }

        public IEnumerator<IComponent> GetEnumerator()
        {
            yield return this;
        }


        IEnumerator IEnumerable.GetEnumerator()
        {
            yield return GetEnumerator();
        }
    }
}
