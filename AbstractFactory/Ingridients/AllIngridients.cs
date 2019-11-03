using System;
using System.Collections.Generic;
using AbstractFactory.Ingridients;
using AbstractFactory.Ingridients.Doughs;
using AbstractFactory.Ingridients.Souces;
using AbstractFactory.Ingridients.Cheeses;
using AbstractFactory.Ingridients.Veggies;
using AbstractFactory.Ingridients.Pepperinies;
using AbstractFactory.Ingridients.Clams;

namespace AbstractFactory.Ingridients
{
    struct AllIngridients
    {
        public Dough Dough;
        public Souce Souce;
        public Cheese Cheese;
        public IEnumerable<Veggy> Veggies;
        public Pepperoni Pepperoni;
        public Clam Clam;

        public List<IIngridient> Ingridients;

        public void FillAllIngridients()
        {
            Ingridients = new List<IIngridient>();
            AddIngridient(Dough);
            AddIngridient(Souce);
            AddIngridients(Veggies);
            AddIngridient(Cheese);
            AddIngridient(Pepperoni);
            AddIngridient(Clam);
        }

        public void PrintIngridients()
        {
            if (Ingridients == null)
            {
                FillAllIngridients();
            }
            foreach (var ingridient in Ingridients)
            {
                Console.WriteLine(" " + ingridient.GetDisplayName());
            }
        }

        private void AddIngridient(IIngridient ingridient)
        {
            if (ingridient != null && ! Ingridients.Contains(ingridient))
            {
                Ingridients.Add(ingridient);
            }
        }

        private void AddIngridients(IEnumerable<IIngridient> ingridients)
        {
            if (ingridients != null)
            {
                foreach (var ingridient in ingridients)
                {
                    AddIngridient(ingridient);
                }
            }
        }
    }
}
