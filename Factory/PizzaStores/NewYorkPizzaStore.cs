using Factory.Pizzas.RegionAbstractFactory;
using Factory.Pizzas;

namespace Factory.PizzaStores
{
    /// <summary>
    /// Concrete creator
    /// </summary>
    public class NewYorkPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string pizzaType)
        {
            var pizzaRegionFactory = new NewYorkPizzaRegionAbstractFactory();
            var pizza = PizzaStoreHelper.CreatePizzaByTypeAndRegion(pizzaType, pizzaRegionFactory);
            return pizza;
        }

    }
}
