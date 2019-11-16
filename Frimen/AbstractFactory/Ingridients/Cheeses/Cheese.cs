namespace AbstractFactory.Ingridients.Cheeses
{
    abstract class Cheese : IIngridient
    {
        public virtual string GetDisplayName()
        {
            return GetType().Name;
        }
    }
}
