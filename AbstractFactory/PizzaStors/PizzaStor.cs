using System;
using AbstractFactory.Pizzas;
using AbstractFactory.Ingridients;

namespace AbstractFactory.PizzaStors
{
    abstract class PizzaStor
    {
        public void OrderPizza(PizzaTypes pizzaType)
        {
            Pizza pizza = CreatePizza(pizzaType);
            if (pizza != null)
            {
                pizza.MakePizza();
            }
            else
            {
                throw new NullReferenceException("Pizza is null");
            }
        }

        public abstract Pizza CreatePizza(PizzaTypes pizzaType);
    }
}
