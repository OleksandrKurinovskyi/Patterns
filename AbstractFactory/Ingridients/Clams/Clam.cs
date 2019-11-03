namespace AbstractFactory.Ingridients.Clams
{
    abstract class Clam : IIngridient
    {
        public virtual string GetDisplayName()
        {
            return GetType().Name;
        }
    }
}
