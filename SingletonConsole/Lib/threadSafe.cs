using System;
using System.Threading;

namespace SingletonConsole
{
    public class ThreadSafe
    {
        public static void run()
        { 
            Singleton newInst = Singleton.getInstance();

            Console.WriteLine(string.Format("Thread ID = {0} \n", Thread.CurrentThread.ManagedThreadId));
            Console.WriteLine("Number of cards remaining in deck : "+newInst.Deck.Count+"\n");
            string s = null;
            if (newInst.Deck.Count == 0)
            {
                s = "A deck contains maximum of 52 cards.";
            }
            else
            {
                foreach (var item in newInst.getPlayerCards(13))
                {
                    s += string.Format("{0},{1}\t", item.CardSuit, item.CardValue);
                }
            }
            s += "\n";
            Console.WriteLine(s);
            Console.WriteLine("Number of cards remaining in deck : " + newInst.Deck.Count + "\n");
            Console.WriteLine("----------------------------------------------------------");
        }

    }
}
