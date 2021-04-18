using System;
using System.Collections.Generic;
using System.Text;

namespace DeckOfCards
{
    class Cards
    {
        public List<string> Suit { get; private set; }
        public List<string> Value { get; private set; }

        //Creates each card
        public Cards()
        {
            Suit = new List<string> { "Spades", "Clubs", "Hearts", "Diamonds" };
            Value = new List<string> { "2", "3", "4", "5", "6", "7", "8", "9", "10",
                                       "Ace", "Queen", "Jack", "King"};
        }

        //Makes a set of unqiue cards
        public List<string> GetSetOfCards()
        {
            List<string> cardsSet = new List<string>();

            foreach (var suit in Suit) foreach (var value in Value) cardsSet.Add(value + " of " + suit);

            return cardsSet;
        }
    }
}