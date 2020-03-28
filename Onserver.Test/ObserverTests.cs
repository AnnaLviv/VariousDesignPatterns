using NUnit.Framework;
using Observer.ObserverElements;
using Observer.Subject;
using System;

namespace Observer.Test
{
    [TestFixture]
    public class ObserverTests
    {
        [Test]
        public void CompleteObserverTest()
        {
            var color = new Color();
            var cat = new Cat(color);
            var dog = new Dog(color);
            Assert.IsTrue(string.IsNullOrEmpty(cat.Miauw));
            Assert.IsTrue(string.IsNullOrEmpty(dog.Woof));

            var newColor = ConsoleColor.Green;
            color.SetState(newColor);
            Assert.IsTrue(cat.Miauw.Contains(newColor.ToString()));
            Assert.IsTrue(dog.Woof.Contains(newColor.ToString()));

            newColor = ConsoleColor.Blue;
            color.SetState(newColor);
            Assert.IsTrue(cat.Miauw.Contains(newColor.ToString()));
            Assert.IsTrue(dog.Woof.Contains(newColor.ToString()));

        }
    }
}
