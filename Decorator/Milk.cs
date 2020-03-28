
namespace Decorator
{
    public class Milk:CondimentDecorator
    {
        private readonly Beverage beverage;
        public Milk(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override double GetCost()
        {
            return beverage.GetCost() + 0.20;
        }

        public override string GetDescription() => $"{beverage.GetDescription()}, Mocha";

    }
}
