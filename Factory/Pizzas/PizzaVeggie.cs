using Factory.Pizzas.Ingredients;
using Factory.Pizzas.RegionAbstractFactory;
using System.Collections.Generic;

namespace Factory.Pizzas
{
    public class PizzaVeggie : Pizza
    {
        public PizzaVeggie(IPizzaRegionAbstractFactory pizzaRegionFactory) :
            base("Vegetarian", 
                new List<Topping> 
                { Topping.Corn, Topping.Tomato, Topping.Mushrooms, Topping.Paprika, Topping.Onion },
                Cheese.French,
               pizzaRegionFactory)
        {
        }
    }
}
