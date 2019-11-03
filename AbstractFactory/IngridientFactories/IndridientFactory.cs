using AbstractFactory.Ingridients.Doughs;
using AbstractFactory.Ingridients.Souces;
using AbstractFactory.Ingridients.Cheeses;
using AbstractFactory.Ingridients.Veggies;
using AbstractFactory.Ingridients.Pepperinies;
using AbstractFactory.Ingridients.Clams;
using System.Collections.Generic;

namespace AbstractFactory.IngridientFactories
{
    abstract class IngridientFactory
    {
        public abstract Dough CreateDough();

        public abstract Souce CreateSouce();

        public abstract Cheese CreateChees();

        public abstract IEnumerable<Veggy> CreateVeggies();

        public abstract Pepperoni CreatePepperoni();

        public abstract Clam CreateClam();
    }
}
