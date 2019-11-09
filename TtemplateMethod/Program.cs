using TitleLib;
using System.Reflection;
using System;

namespace TtemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Title.UpperIndent(Assembly.GetExecutingAssembly());

            Beverage coffee = new Coffee();
            coffee.CustomerWantsCondiments = false;
            coffee.PrepareBeverage();

            System.Console.WriteLine();

            Beverage tea = new Tea();
            tea.PrepareBeverage();

            Title.BottonIndent();
        }
    }
}
