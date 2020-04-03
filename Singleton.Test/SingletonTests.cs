using NUnit.Framework;

namespace Singleton.Test
{
    public class Tests
    {

        [Test]
        public void SingletonLazyTest()
        {
            var instance = SingletonLazy.GetInstance();
            Assert.AreEqual(1000, instance.IntVariable);

            instance.SetIntVariable(20);
            Assert.AreEqual(20, instance.IntVariable);
        }

        [Test]
        public void SingletonEagerTest()
        {
            var instance = SingletonEager.GetInstance();
            Assert.AreEqual(1000, instance.IntVariable);

            instance.SetIntVariable(20);
            Assert.AreEqual(20, instance.IntVariable);
        }
    }
}