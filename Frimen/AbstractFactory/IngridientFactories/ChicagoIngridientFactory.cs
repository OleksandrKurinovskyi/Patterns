using AbstractFactory.Ingridients.Doughs;
using AbstractFactory.Ingridients.Souces;
using AbstractFactory.Ingridients.Cheeses;
using AbstractFactory.Ingridients.Veggies;
using AbstractFactory.Ingridients.Pepperinies;
using AbstractFactory.Ingridients.Clams;
using System.Collections.Generic;

namespace AbstractFactory.IngridientFactories
{
    class ChicagoIngridientFactory : IngridientFactory
    {
        public override Dough CreateDough()
        {
            return new DoughTwo();
        }

        public override Souce CreateSouce()
        {
            return new SouceTwo();
        }

        public override IEnumerable<Veggy> CreateVeggies()
        {
            return new List<Veggy>() { new VeggyTwo(), new VeggyTwo() };
        }

        public override Pepperoni CreatePepperoni()
        {
            return new PepperoniTwo();
        }

        public override Cheese CreateChees()
        {
            return new CheeseTwo();
        }

        public override Clam CreateClam()
        {
            return new ClamTwo();
        }
    }
}
