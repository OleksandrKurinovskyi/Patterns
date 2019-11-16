using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adapter.Ducks;
using Adapter.Turkies;

namespace Adapter
{
    class AdapterTurkeyToDuck : IDuck
    {
        private ITurkey _turkey;

        public AdapterTurkeyToDuck(ITurkey turkey)
        {
            _turkey = turkey;
        }

        public void Quack()
        {
            _turkey.Gobble();
        }

        public void Fly()
        {
            for (int i = 0; i < 5; i++)
            {
                _turkey.Fly();
            }
        }
    }
}
