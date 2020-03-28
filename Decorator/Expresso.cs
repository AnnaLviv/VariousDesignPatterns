namespace Decorator
{
    public class Expresso:Beverage
    {
        public Expresso()
        { 
            Description = "Expresso";
        }

        public override double GetCost()
        {
            return 1.99;
        }
    }
}
