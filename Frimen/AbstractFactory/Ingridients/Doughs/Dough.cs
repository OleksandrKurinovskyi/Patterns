namespace AbstractFactory.Ingridients.Doughs
{
    abstract class Dough : IIngridient
    {
        public virtual string GetDisplayName()
        {
            return GetType().Name;
        }
    }
}
