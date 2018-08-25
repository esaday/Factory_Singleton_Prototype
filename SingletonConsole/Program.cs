using System;
using System.Threading;

namespace SingletonConsole
{
    class Program
    {
        static void Main(string[] args)
        {  
            for (int i = 0; i < 5; i++)
            {
                Thread t = new Thread(new ThreadStart(ThreadSafe.run));
                t.Start();
                t.Join(); //Used for visual stability 
            }

            Console.ReadKey();
        }
    }
}
