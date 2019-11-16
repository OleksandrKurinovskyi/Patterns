using AbstractFactory.Ingridients.Doughs;
using AbstractFactory.Ingridients.Souces;
using AbstractFactory.Ingridients.Cheeses;
using AbstractFactory.Ingridients.Veggies;
using AbstractFactory.Ingridients.Pepperinies;
using AbstractFactory.Ingridients.Clams;
using System.Collections.Generic;

namespace AbstractFactory.IngridientFactories
{
    class NYIngridientFactory : IngridientFactory
    {
        public override Dough CreateDough()
        {
            return new DoughOne();
        }

        public override Souce CreateSouce()
        {
            return new SouceOne();
        }

        public override IEnumerable<Veggy> CreateVeggies()
        {
            return new List<Veggy>() { new VeggyOne(), new VeggyOne() };
        }

        public override Pepperoni CreatePepperoni()
        {
            return new PepperoniOne();
        }

        public override Cheese CreateChees()
        {
            return new CheeseOne();
        }

        public override Clam CreateClam()
        {
            return new ClamOne();
        }
    }
}
