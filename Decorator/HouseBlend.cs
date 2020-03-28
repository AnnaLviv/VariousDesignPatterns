namespace Decorator
{
    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            Description = "House Blend";
        }

        public override double GetCost()
        {
            return 0.99;
        }
    }
}
