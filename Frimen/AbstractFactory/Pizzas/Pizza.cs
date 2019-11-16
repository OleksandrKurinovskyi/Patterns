using System;
using System.Collections.Generic;
using System.Reflection;
using AbstractFactory.Ingridients;
using AbstractFactory.Ingridients.Doughs;
using AbstractFactory.Ingridients.Souces;
using AbstractFactory.Ingridients.Cheeses;
using AbstractFactory.Ingridients.Veggies;
using AbstractFactory.Ingridients.Pepperinies;
using AbstractFactory.Ingridients.Clams;
using AbstractFactory.IngridientFactories;

namespace AbstractFactory.Pizzas
{
    abstract class Pizza
    {
        private string _name;

        protected IngridientFactory IngridientFactory;

        public AllIngridients AllIngridients;

        public Pizza(IngridientFactory indridientFactory)
        {
            _name = this.GetType().Name;
            IngridientFactory = indridientFactory;
        }

        public abstract void Prepare();

        private void PrepareInternal()
        {
            Print(MethodBase.GetCurrentMethod().Name);
            Prepare();
            AllIngridients.PrintIngridients();
        }

        protected virtual void Bake()
        {
            Print(MethodBase.GetCurrentMethod().Name);
        }

        protected virtual void Cut()
        {
            Print(MethodBase.GetCurrentMethod().Name);
        }

        protected virtual void Box()
        {
            Print(MethodBase.GetCurrentMethod().Name);
        }

        public void MakePizza()
        {
            PrepareInternal();
            Bake();
            Cut();
            Box();
        }

        protected void Print(string actionName)
        {
            Console.WriteLine(_name + " - " + actionName);
        }
    }
}
