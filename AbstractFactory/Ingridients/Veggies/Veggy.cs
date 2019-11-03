namespace AbstractFactory.Ingridients.Veggies
{
    abstract class Veggy : IIngridient
    {
        public virtual string GetDisplayName()
        {
            return GetType().Name;
        }
    }
}
