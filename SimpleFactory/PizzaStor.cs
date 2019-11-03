using System;
using SimpleFactory.Pizzas;

namespace SimpleFactory
{
    class PizzaStor
    {
        public SimplePizzaFactory SimplePizzaFactory { get; set; }

        public PizzaStor(SimplePizzaFactory simplePizzaFactory)
        {
            SimplePizzaFactory = simplePizzaFactory;
        }

        public void OrderPizza(PizzaTypes pizzaType)
        {
            if (SimplePizzaFactory == null)
            {
                throw new NullReferenceException("SimplePizzaFactory in null");
            }
            Pizza pizza = SimplePizzaFactory.CreatePizza(pizzaType);
            pizza.MakePizza();
        }
    }
}
