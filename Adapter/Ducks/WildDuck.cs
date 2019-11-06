using System;

namespace Adapter.Ducks
{
    class WildDuck : IDuck
    {
        public void Quack()
        {
            Console.WriteLine("{0} quacks", this.GetType().Name);
        }

        public void Fly()
        {
            Console.WriteLine("{0} flys LONG", this.GetType().Name);
        }
    }
}
