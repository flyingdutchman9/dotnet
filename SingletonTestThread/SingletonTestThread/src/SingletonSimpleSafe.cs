using System;
namespace SingletonTestThread.src
{
    public sealed class SingletonSimpleSafe
    {
        private static SingletonSimpleSafe instance;
        private static readonly object padlock = new object();

        private SingletonSimpleSafe()
        {
        }

        public static SingletonSimpleSafe Instance
        {
            get
            {
                lock (padlock)
                {

                    if (instance == null)
                    {
                        Console.WriteLine("Creating new instance");
                        instance = new SingletonSimpleSafe();
                        //Thread.Sleep(2000);
                    }


                    return instance;
                }
            }

        }

        internal void WriteToConsole(string threadName)
        {
            Console.WriteLine("Singleton simple safe from thread: " + threadName);
        }
    }
}

