using Factory.Pizzas.Ingredients;
using Factory.Pizzas.Styles;

namespace Factory.Pizzas.RegionAbstractFactory
{
    
    public interface IPizzaRegionAbstractFactory
    {
        Dough CreateDough();
        Sauce CreateSauce();
        Crust CreateCrust();
        SauceQuantity CreateSauceQuantity();
    }
}
