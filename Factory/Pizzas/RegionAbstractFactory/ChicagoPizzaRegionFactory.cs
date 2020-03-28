using Factory.Pizzas.Ingredients;
using Factory.Pizzas.Styles;

namespace Factory.Pizzas.RegionAbstractFactory
{
    public class ChicagoPizzaRegionAbstractFactory : IPizzaRegionAbstractFactory
    {
        public Crust CreateCrust() => Crust.Thick;

        public Dough CreateDough() => Dough.American;

        public Sauce CreateSauce() => Sauce.Cream;

        public SauceQuantity CreateSauceQuantity() => SauceQuantity.Large;
    }
}
