using Factory.Pizzas.Ingredients;
using Factory.Pizzas.RegionAbstractFactory;
using Factory.Pizzas.Styles;
using System;
using System.Collections.Generic;

namespace Factory.Pizzas
{
    public abstract class Pizza
    {
        public string Name { get; }
        public IEnumerable<Topping> Toppings { get; }
        public Cheese Cheese { get; }
        public Dough Dough { get; }
        public Sauce Sauce { get; }
        public Crust Crust { get; }
        public SauceQuantity SauceQuantity { get; }
        protected Pizza(string name, IEnumerable<Topping> toppings, Cheese cheese, IPizzaRegionAbstractFactory pizzaRegionAbstractFactory)
        {
            Name = name;
            Toppings = toppings;
            Cheese = cheese;
            Dough = pizzaRegionAbstractFactory.CreateDough();
            Sauce = pizzaRegionAbstractFactory.CreateSauce();
            Crust = pizzaRegionAbstractFactory.CreateCrust();
            SauceQuantity = pizzaRegionAbstractFactory.CreateSauceQuantity();
        }

        public void Prepare()
        {
            Console.WriteLine($"Preparing pizza '{Name}'");
            Console.WriteLine($"Tossing dough '{Dough}' with {Crust} crust");
            Console.WriteLine($"Adding sauce '{Sauce}' of {SauceQuantity} quanity");
            Console.WriteLine($"Adding toppings:");
            Console.Write(string.Join(", ", Toppings));
        }

        public void Bake()
        {
            Console.WriteLine($"Baking for 15 minutes");
        }

        public void Cut()
        {
            Console.WriteLine($"Cutting the pizza into 8 slices");
        }

        public void Box()
        {
            Console.WriteLine($"Placing pizza into official box");
        }
    }
}
