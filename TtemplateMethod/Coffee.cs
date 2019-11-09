using System;

namespace TemplateMethod
{
    class Coffee : Beverage
    {
        protected override void MakeBeverage()
        {
            Console.WriteLine("Make coffee");
        }

        protected override void AddCondiments()
        {
            Console.WriteLine("Add milk");
        }
    }
}
