using System;
using FactoryMethod.Pizzas;
using FactoryMethod.Pizzas.NYPizza;
using FactoryMethod.Pizzas.Chicago;

namespace FactoryMethod.PizzaStors
{
    class NYPizzaStor : PizzaStor
    {
        public override Pizza CreatePizza(PizzaTypes pizzaType)
        {
            Pizza pizza = null;
            switch (pizzaType)
            {
                case PizzaTypes.Cheese:
                    pizza = new NYCheesePizza();
                    break;
                case PizzaTypes.Greek:
                    pizza = new NYGreekPizza();
                    break;
                case PizzaTypes.Papperoni:
                    pizza = new NYPapperoniPizza();
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
