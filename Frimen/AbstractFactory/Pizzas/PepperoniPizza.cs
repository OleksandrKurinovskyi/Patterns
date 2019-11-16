using AbstractFactory.IngridientFactories;

namespace AbstractFactory.Pizzas
{
    class PepperoniPizza : Pizza
    {
        public PepperoniPizza(IngridientFactory ingridientFactory)
            : base(ingridientFactory)
        {

        }

        public override void Prepare()
        {
            AllIngridients.Dough = IngridientFactory.CreateDough();
            AllIngridients.Cheese = IngridientFactory.CreateChees();
            AllIngridients.Souce = IngridientFactory.CreateSouce();
            AllIngridients.Pepperoni = IngridientFactory.CreatePepperoni();
        }
    }
}
