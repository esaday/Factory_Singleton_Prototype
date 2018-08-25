using System;
using FactoryConsole.Lib;


namespace FactoryConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //Demonstration occurs here!
            HungerGame h = new HungerGame();
            h.CreatePop(100);

            Console.WriteLine(h.Winner());
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(h.AdditiveSurvS[i]);
            }

            Console.ReadKey();
        }
    }
}
