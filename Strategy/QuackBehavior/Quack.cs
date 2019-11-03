using System;

namespace Strategy.QuackBehavior
{
    class Quack : IQuackBehavior
    {
        public void DoQuack()
        {
            Console.WriteLine("QUACK");
        }
    }
}
