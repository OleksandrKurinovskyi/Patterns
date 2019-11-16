using System;
using System.Reflection;

namespace SimpleFactory.Pizzas
{
    abstract class Pizza
    {
        protected virtual void Prepare()
        {
            Print(this.GetType().Name, MethodBase.GetCurrentMethod().Name);
        }

        protected virtual void Bake()
        {
            Print(this.GetType().Name, MethodBase.GetCurrentMethod().Name);
        }

        protected virtual void Cut()
        {
            Print(this.GetType().Name, MethodBase.GetCurrentMethod().Name);
        }

        protected virtual void Box()
        {
            Print(this.GetType().Name, MethodBase.GetCurrentMethod().Name);
        }

        public void MakePizza()
        {
            Prepare();
            Bake();
            Cut();
            Box();
        }

        private void Print(string pizzaName, string actionName)
        {
            Console.WriteLine(pizzaName + " - " + actionName);
        }
    }
}
