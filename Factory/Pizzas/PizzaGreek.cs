using Factory.Pizzas.Ingredients;
using Factory.Pizzas.RegionAbstractFactory;
using System.Collections.Generic;

namespace Factory.Pizzas
{
    public class PizzaGreek : Pizza
    {
        public PizzaGreek(IPizzaRegionAbstractFactory pizzaRegionFactory) :
            base("Greek", 
                new List<Topping> { Topping.GyrosMeat, Topping.Tomato, Topping.Onion }, 
                Cheese.French,
                pizzaRegionFactory)
        {
        }
    }
}