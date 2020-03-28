using Factory.Pizzas;
using Factory.Pizzas.RegionAbstractFactory;

namespace Factory.PizzaStores
{
    /// <summary>
    /// Concrete Creator
    /// </summary>
    public class ChicagoPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string pizzaType)
        {
            var pizzaRegionAbstractFactory = new ChicagoPizzaRegionAbstractFactory();
            var pizza = PizzaStoreHelper.CreatePizzaByTypeAndRegion(pizzaType, pizzaRegionAbstractFactory);
            return pizza;
        }
    }
}
