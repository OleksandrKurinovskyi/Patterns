namespace Decorator.Beverages
{
    abstract class Beverage
    {
        private string _description;

        private float _cost;

        public Size Size { get; private set; }

        public virtual float GetCost()
        {
            return GetMultiplierSize() * _cost;
        }

        public virtual string GetDescription()
        {
            return _description;
        }

        public Beverage(string description, float cost, Size size) 
        {
            _description = description;
            _cost = cost;
            Size = size;
        }

        private float GetMultiplierSize()
        {
            switch(Size)
            {
                case Size.Small: return 0.8f;
                case Size.Normall: return 1.0f;
                case Size.Big: return 1.2f;
                default: return 1.0f;
            }
        }
    }
}
