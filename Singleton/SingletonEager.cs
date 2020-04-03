namespace Singleton
{
    public class SingletonEager
    {
        private static SingletonEager uniqueInstance = new SingletonEager();
        public int IntVariable { get; private set; }
        private SingletonEager()
        {
            IntVariable = 1000;
        }

        public static SingletonEager GetInstance()
        {
            return uniqueInstance;
        }

        public void SetIntVariable(int newValue)
        {
            IntVariable = newValue;
        }
    }
}
