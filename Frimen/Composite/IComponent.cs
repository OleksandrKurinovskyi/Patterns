using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    interface IComponent : IEnumerable<IComponent>
    {
        void Option();

        void Add(IComponent component);

        void Remove(IComponent component);
    }
}
