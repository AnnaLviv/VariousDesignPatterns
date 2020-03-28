namespace Decorator
{
    public abstract class Beverage
    {
        protected string Description;
        public virtual string GetDescription() => Description;
        public abstract double GetCost();
        public Beverage()
        {
            Description = "Unknown Descirption";
        }

    }
}
