﻿using System;

namespace TemplateMethod
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
