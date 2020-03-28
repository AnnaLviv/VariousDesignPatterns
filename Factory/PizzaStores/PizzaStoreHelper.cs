using Factory.Pizzas.RegionAbstractFactory;
using Factory.Pizzas;
using System.ComponentModel;

namespace Factory.PizzaStores
{
    public static class PizzaStoreHelper
    {
        public static Pizza CreatePizzaByTypeAndRegion(string pizzaType, IPizzaRegionAbstractFactory pizzaRegionAbstractFactory)
        {
            switch (pizzaType)
            {
                case "MeatLover":
                    {
                        return new PizzaMeatLover(pizzaRegionAbstractFactory);
                    }
                case "Pepperoni":
                    {
                        return new PizzaPepperoni(pizzaRegionAbstractFactory);
                    }
                case "Veggie":
                    {
                        return new PizzaVeggie(pizzaRegionAbstractFactory);
                    }
                case "Greek":
                    {
                        return new PizzaGreek(pizzaRegionAbstractFactory);
                    }
                default:
                    throw new InvalidEnumArgumentException($"Pizza type {pizzaType} is not supported.");
            }
        }
    }
}
