using System;
using FactoryMethod.Pizzas;
using FactoryMethod.Pizzas.NYPizza;
using FactoryMethod.Pizzas.Chicago;

namespace FactoryMethod.PizzaStors
{
    class ChicagoPizzaStor : PizzaStor
    {
        public override Pizza CreatePizza(PizzaTypes pizzaType)
        {
            Pizza pizza = null;
            switch (pizzaType)
            {
                case PizzaTypes.Cheese:
                    pizza = new ChicagoCheesePizza();
                    break;
                case PizzaTypes.Greek:
                    pizza = new ChicagoGreekPizza();
                    break;
                case PizzaTypes.Papperoni:
                    pizza = new ChicagoPapperoniPizza();
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
