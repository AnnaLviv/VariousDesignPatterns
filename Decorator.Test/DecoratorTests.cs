using NUnit.Framework;

namespace Decorator.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Beverage beverage = new Expresso();
            Assert.IsTrue(System.Math.Abs(beverage.GetCost()- 1.99)<0.0001);

            Beverage beverage2 = new HouseBlend();
            Assert.IsTrue(System.Math.Abs(beverage2.GetCost() - 0.99) < 0.0001);
            beverage2 = new Milk(beverage2);
            beverage2 = new Syrup(beverage2);

            Assert.IsTrue(System.Math.Abs(beverage2.GetCost() - 1.69) < 0.0001);
        }
    }
}