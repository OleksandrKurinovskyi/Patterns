using System;

namespace Adapter.Turkies
{
    class WildTurkey : ITurkey
    {
        public void Gobble()
        {
            Console.WriteLine("{0} gobbles", this.GetType().Name);
        }

        public void Fly()
        {
            Console.WriteLine("{0} fly SHORT", this.GetType().Name);

        }
    }
}
