namespace Decorator.Beverages
{
    class Coffee : Beverage
    {
        public Coffee(string description, float cost, Size size = Size.Normall)
            : base(description, cost, size)
        {
        }
    }
}
