using Factory.Pizzas.Ingredients;
using Factory.Pizzas.Styles;

namespace Factory.Pizzas.RegionAbstractFactory
{
    public class NewYorkPizzaRegionAbstractFactory : IPizzaRegionAbstractFactory
    {
        public Dough CreateDough() => Dough.Italian;

        public Sauce CreateSauce() => Sauce.Bbq;

        public Crust CreateCrust() => Crust.Thin;

        public SauceQuantity CreateSauceQuantity() => SauceQuantity.Medium;
    }
}
