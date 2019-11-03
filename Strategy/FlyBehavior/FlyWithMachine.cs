using System;

namespace Strategy.FlyBehavior
{
    class FlyWithMachine : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("Fly with machine");
        }
    }
}
