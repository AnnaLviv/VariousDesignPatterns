namespace Decorator
{
    public  class Syrup:CondimentDecorator
    {
        private readonly Beverage beverage;
        public Syrup(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override double GetCost()
        {
            return beverage.GetCost() + 0.50;
        }

        public override string GetDescription() => $"{beverage.GetDescription()}, Syrup";
    }
}
