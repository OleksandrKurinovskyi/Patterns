using System;
using AbstractFactory.Pizzas;
using AbstractFactory.Ingridients.Doughs;
using AbstractFactory.Ingridients.Souces;
using AbstractFactory.Ingridients.Cheeses;
using AbstractFactory.Ingridients.Veggies;
using AbstractFactory.Ingridients.Pepperinies;
using AbstractFactory.Ingridients.Clams;
using System.Collections.Generic;
using AbstractFactory.Ingridients;
using AbstractFactory.IngridientFactories;

namespace AbstractFactory.PizzaStors
{
    class NYPizzaStor : PizzaStor
    {
        public override Pizza CreatePizza(PizzaTypes pizzaType)
        {
            Pizza pizza = null;
            IngridientFactory ingridientFactory = new NYIngridientFactory();
            switch (pizzaType)
            {
                case PizzaTypes.Cheese:
                    pizza = new CheesePizza(ingridientFactory);
                    break;
                case PizzaTypes.Greek:
                    pizza = new GreekPizza(ingridientFactory);
                    break;
                case PizzaTypes.Papperoni:
                    pizza = new PepperoniPizza(ingridientFactory);
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
