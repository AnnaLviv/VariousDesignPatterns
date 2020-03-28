using Factory.Pizzas.Ingredients;
using Factory.Pizzas.RegionAbstractFactory;
using System.Collections.Generic;

namespace Factory.Pizzas
{
    public class PizzaMeatLover : Pizza
    {
        public PizzaMeatLover(IPizzaRegionAbstractFactory pizzaRegionFactory) :
            base("Meat Lover", 
                new List<Topping> 
                { Topping.Beef, Topping.Chicken, Topping.Bacon, Topping.Tomato, Topping.Onion },
                Cheese.American,
                pizzaRegionFactory)
        {
        }
    }
}