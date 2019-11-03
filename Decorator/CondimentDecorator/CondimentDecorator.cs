using Decorator.Beverages;

namespace Decorator.CondimentDecorator
{
    abstract class CondimentDecorator : Beverage
    {
        protected Beverage Beverage;

        public CondimentDecorator(string description, float cost, Beverage beverage)
            : base(description, cost, beverage.Size)
        {
            Beverage = beverage;
        }

        public override float GetCost()
        {
            if (Beverage != null)
            {
                return base.GetCost() + Beverage.GetCost();
            }
            else
            {
                throw null;
            }
        }

        public override string GetDescription()
        {
            if (Beverage != null)
            {
                return Beverage.GetDescription() + " + " + base.GetDescription();
            }
            else
            {
                throw null;
            }
        }
    }
}
