namespace Singleton
{
    public class SingletonLazy
    {
        private static SingletonLazy uniqueInstance;
        private static readonly object lockObject = new object();
        public int IntVariable { get; private set; }
        private SingletonLazy() 
        {
            IntVariable = 1000;
        }

        public static SingletonLazy GetInstance()
        {
            if(uniqueInstance is null)
            {
                lock (lockObject)
                {
                    if (uniqueInstance is null)
                    {
                        uniqueInstance = new SingletonLazy();
                    }
                }
            }

            return uniqueInstance;
        }

        public void SetIntVariable(int newValue)
        {
            IntVariable = newValue;
        }
    }
}
