using AbstractFactory.IngridientFactories;

namespace AbstractFactory.Pizzas
{
    class CheesePizza : Pizza
    {
        public CheesePizza(IngridientFactory ingridientFactory)
            : base(ingridientFactory)
        {
        }

        public override void Prepare()
        {
            AllIngridients.Dough = IngridientFactory.CreateDough();
            AllIngridients.Cheese = IngridientFactory.CreateChees();
            AllIngridients.Souce = IngridientFactory.CreateSouce();
        }
    }
}
