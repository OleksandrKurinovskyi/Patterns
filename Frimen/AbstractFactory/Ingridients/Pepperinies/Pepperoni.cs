namespace AbstractFactory.Ingridients.Pepperinies
{
    abstract class Pepperoni : IIngridient
    {
        public virtual string GetDisplayName()
        {
            return GetType().Name;
        }
    }
}
