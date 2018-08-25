using System.Collections.Generic;

namespace SingletonConsole
{
    class Singleton
    {
        private static readonly Singleton firstInst = new Singleton(); //makes things thread-safe

        private LinkedList<Card> deck = Card.getDeck(); //getting shuffled and complete deck & "public" for getting the count!

        private Singleton() { /*Private ctor*/  }

        internal LinkedList<Card> Deck
        {
            get
            {
                return deck;
            }

            private set
            {
                deck = value;
            }
        }

        public static Singleton getInstance() { return firstInst; }

        /// <summary>
        /// Getting specified number of cards from the deck.
        /// </summary>
        /// <param name="count">Number of cards per player</param>
        /// <returns>Returns linkedlist containing specified number of cards from shuffled deck </returns>
        public LinkedList<Card> getPlayerCards(int count)
        {
            LinkedList<Card> cardsToSend = new LinkedList<Card>();
                for (int i = 0; i < count; i++)
                {
                    cardsToSend.AddLast(firstInst.Deck.First.Value);
                    firstInst.Deck.RemoveFirst();
                }
                return cardsToSend;
        }

    }
}
