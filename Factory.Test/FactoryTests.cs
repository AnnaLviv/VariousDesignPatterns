using Factory.PizzaStores;
using Factory.Pizzas.Styles;
using NUnit.Framework;

namespace Factory.Test
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void VariousPizzaStoresTest()
        {
            var newYorkPizzaStore = new NewYorkPizzaStore();
            var chicagoPizzaStore = new ChicagoPizzaStore();

            var newYourkStylePizzaMeatLover = newYorkPizzaStore.OrderPizza("MeatLover");
            var chicagoPepperoniPizza = chicagoPizzaStore.OrderPizza("Pepperoni");

            Assert.AreEqual(Crust.Thin, newYourkStylePizzaMeatLover.Crust);
            Assert.AreEqual(Crust.Thick, chicagoPepperoniPizza.Crust);
        }
    }
}