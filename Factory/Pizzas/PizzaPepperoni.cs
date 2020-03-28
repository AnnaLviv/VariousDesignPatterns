using Factory.Pizzas.Ingredients;
using Factory.Pizzas.RegionAbstractFactory;
using System.Collections.Generic;

namespace Factory.Pizzas
{
    public class PizzaPepperoni : Pizza
    {
        public PizzaPepperoni(IPizzaRegionAbstractFactory pizzaRegionFactory) :
            base("Pepperoni", 
                new List<Topping> { Topping.Pepperoni, Topping.Paprika, Topping.Onion },
                Cheese.Gouda,
                pizzaRegionFactory)
        {
        }
    }
}
