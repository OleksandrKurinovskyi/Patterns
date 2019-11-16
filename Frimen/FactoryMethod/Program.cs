using System;
using TitleLib;
using System.Reflection;
using FactoryMethod.Pizzas;
using FactoryMethod.PizzaStors;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Title.UpperIndent(Assembly.GetExecutingAssembly());

            PizzaStor nyPizzaStror = new NYPizzaStor();
            nyPizzaStror.OrderPizza(PizzaTypes.Greek);

            Title.BottonIndent();
        }
    }
}
