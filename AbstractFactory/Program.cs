using System;
using TitleLib;
using System.Reflection;
using AbstractFactory.Pizzas;
using AbstractFactory.PizzaStors;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Title.UpperIndent(Assembly.GetExecutingAssembly());

            PizzaStor nyPizzaStror = new ChicagoPizzaStor();
            nyPizzaStror.OrderPizza(PizzaTypes.Cheese);

            Title.BottonIndent();
        }
    }
}
