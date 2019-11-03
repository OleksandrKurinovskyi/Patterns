using System;
using TitleLib;
using System.Reflection;
using Decorator.Beverages;
using Decorator.CondimentDecorator;
using System.Collections.Generic;

namespace Decorator
{
    public enum Size
    {
        Small,
        Normall,
        Big
    }

    class Program
    {
        static void Main(string[] args)
        {
            Title.UpperIndent(Assembly.GetExecutingAssembly());

            Beverage beverage1 = new Coffee("Simple coffee", 20, Size.Small);
            Beverage beverage2 = new Milk("Milk", 4, beverage1);
            Beverage beverage3 = new Milk("Milk", 4, beverage2);

            Console.WriteLine(beverage3.GetCost());
            Console.WriteLine(beverage3.GetDescription());

            Title.BottonIndent();
        }
    }
}
