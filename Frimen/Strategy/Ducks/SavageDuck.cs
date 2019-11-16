using Strategy.FlyBehavior;
using Strategy.QuackBehavior;
using System;

namespace Strategy.Ducks
{
    class SavageDuck : Duck
    {
        public SavageDuck(IFlyBehavior flyBehavior, IQuackBehavior quackBehavior)
            : base(flyBehavior, quackBehavior)
        {
        }

        public override void Display()
        {
            Console.WriteLine(this.GetType().Name);
        }
    }
}
