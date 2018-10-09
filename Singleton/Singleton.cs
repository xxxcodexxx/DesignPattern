namespace Singleton
{
    public class Singleton
    {
        private static Singleton _instance;

        private static readonly object obj = new object();

        private Singleton() { }

        public static Singleton getInstance()
        {
            lock (obj)
            {
                if (_instance == null)
                    _instance = new Singleton();
            }
            return _instance;
        }
    }
}
