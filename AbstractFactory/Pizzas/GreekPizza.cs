using AbstractFactory.IngridientFactories;

namespace AbstractFactory.Pizzas
{
    class GreekPizza : Pizza
    {
        public GreekPizza(IngridientFactory ingridientFactory)
            : base(ingridientFactory)
        {

        }

        public override void Prepare()
        {
            AllIngridients.Dough = IngridientFactory.CreateDough();
            AllIngridients.Cheese = IngridientFactory.CreateChees();
            AllIngridients.Souce = IngridientFactory.CreateSouce();
            AllIngridients.Veggies = IngridientFactory.CreateVeggies();
            AllIngridients.Clam = IngridientFactory.CreateClam();
        }
    }
}
