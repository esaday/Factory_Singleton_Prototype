using System;
using System.Collections.Generic;
using System.Linq;

namespace SingletonConsole
{
    public enum CardSuit
    {
        Diamonds,
        Spades,
        Hearts,
        Clubs
    }

    public enum CardValue
    {
        Ace = 1,
        Two = 2, Three = 3, Four = 4, Five = 5, Six = 6, Seven = 7, Eight = 8, Nine = 9, Ten = 10,
        Jack = 11,
        Queen = 12,
        King = 13
    }

    class Card
    {
        //Public props, private sets : can be read from outside of the class but cannot set!
        public CardSuit CardSuit { get; private set; }
        public CardValue CardValue { get; private set; }

        //Private ctor.
        private Card(CardSuit cardSuit, CardValue cardValue)
        {
            CardSuit = cardSuit;
            CardValue = cardValue;
        }

        /// <summary>
        /// Method for creating a complete deck
        /// </summary>
        /// <returns>Complete and shuffled deck</returns>
        public static LinkedList<Card> getDeck()
        {
            LinkedList<Card> deck = new LinkedList<Card>();
            var rnd = new Random();

            foreach (CardSuit type in Enum.GetValues(typeof(CardSuit)))
            {
                foreach (CardValue val in Enum.GetValues(typeof(CardValue)))
                {
                    deck.AddLast(new Card(type, val));
                }
            }

            var shuffledDeck = deck.OrderBy(x => rnd.Next()).ToList();
            deck = new LinkedList<Card>(shuffledDeck);
            return deck;
        }
    }
}
