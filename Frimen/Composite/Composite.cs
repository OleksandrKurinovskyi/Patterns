using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Composite : IComponent
    {
        private List<IComponent> _components;

        public Composite()
        {
            _components = new List<IComponent>();
        }

        public void Option()
        {
            foreach (var component in _components)
            {
                component.Option();
            }
        }

        public void Add(IComponent component)
        {
            if (component != null && !_components.Contains(component))
            {
                _components.Add(component);
            }
        }

        public void Remove(IComponent component)
        {
            if (_components.Contains(component))
            {
                _components.Remove(component);
            }
        }

        public IEnumerator<IComponent> GetEnumerator()
        {
            foreach (var item in _components)
            {
                var i = item.GetEnumerator();
                while(i.MoveNext())
                {
                    yield return i.Current;
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            yield return GetEnumerator();
        }
    }
}
