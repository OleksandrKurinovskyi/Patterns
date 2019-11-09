using System;

namespace TtemplateMethod
{
    class Tea : Beverage
    {
        protected override void MakeBeverage()
        {
            Console.WriteLine("Make tea");
        }

        protected override void AddCondiments()
        {
            Console.WriteLine("Add lemone");
        }
    }
}
