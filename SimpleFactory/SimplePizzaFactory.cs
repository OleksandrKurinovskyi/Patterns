using System;
using SimpleFactory.Pizzas;

namespace SimpleFactory
{
    class SimplePizzaFactory
    {
        public Pizza CreatePizza(PizzaTypes pizzaType)
        {
            Pizza pizza = null;
            switch (pizzaType)
            {
                case PizzaTypes.Cheese:
                    pizza = new CheesePizza();
                    break;
                case PizzaTypes.Greek:
                    pizza = new GreekPizza();
                    break;
                case PizzaTypes.Papperoni:
                    pizza = new PapperoniPizza();
                    break;
                default:
                    throw new ArgumentException("Wrong PizzaTypes");
            }
            if (pizza != null)
            {
                return pizza;
            }
            else
            {
                throw new NullReferenceException("Pizza is null");
            }
        }
    }
}
