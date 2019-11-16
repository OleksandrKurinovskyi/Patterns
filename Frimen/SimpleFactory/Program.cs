using System;
using TitleLib;
using System.Reflection;
using SimpleFactory.Pizzas;

namespace SimpleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Title.UpperIndent(Assembly.GetExecutingAssembly());

            SimplePizzaFactory simplePizzaFactory = new SimplePizzaFactory();
            PizzaStor pizzaStor = new PizzaStor(simplePizzaFactory);
            pizzaStor.OrderPizza(PizzaTypes.Greek);

            Title.BottonIndent();
        }
    }
}
