using System;

namespace Strategy.FlyBehavior
{
    class FlyWithWings : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("Fly with wings");
        }
    }
}
