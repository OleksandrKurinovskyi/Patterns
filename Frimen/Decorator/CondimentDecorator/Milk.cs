using Decorator.CondimentDecorator;
using Decorator.Beverages;

namespace Decorator.CondimentDecorator
{
    class Milk : CondimentDecorator
    {
        public Milk(string description, float cost, Beverage beverage)
            : base(description, cost, beverage)
        {
        }
    }
}
