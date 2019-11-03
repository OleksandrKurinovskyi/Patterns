namespace AbstractFactory.Ingridients.Souces
{
    abstract class Souce : IIngridient
    {
        public virtual string GetDisplayName()
        {
            return GetType().Name;
        }
    }
}
