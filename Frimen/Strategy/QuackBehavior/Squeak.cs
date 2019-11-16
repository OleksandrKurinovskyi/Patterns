using System;

namespace Strategy.QuackBehavior
{
    class Squeak : IQuackBehavior
    {
        public void DoQuack()
        {
            Console.WriteLine("SQUEAK");
        }
    }
}
