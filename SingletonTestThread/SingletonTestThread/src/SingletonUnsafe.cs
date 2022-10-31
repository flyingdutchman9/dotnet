using System;
namespace SingletonTestThread.src
{
    public sealed class SingletonUnsafe
    {
        private static SingletonUnsafe instance;

        private SingletonUnsafe() {}

        public static SingletonUnsafe Instance
        {
            get
            {
                if (instance == null)
                {
                    Console.WriteLine("Creating new instance");
                    instance = new SingletonUnsafe();
                }

                return instance;
            }
            
        }

        internal void WriteToConsole(string threadName)
        {
            Console.WriteLine("Singleton from thread: " + threadName);
        }
    }
}

