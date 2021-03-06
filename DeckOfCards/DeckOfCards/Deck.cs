using System;
using System.Collections.Generic;
using System.Text;

namespace DeckOfCards
{
    class Deck
    {
        // Fields
        public List<string> cards { get; private set; }

        // Constructor 
        public Deck()
        {
            cards = new List<string>();
            FillDeck();
        }

        // Fill up the deck when a new object is instansiated
        private void FillDeck()
        {
            Cards setOfCards = new Cards();
            foreach (string card in setOfCards.GetSetOfCards()) cards.Add(card);
        }

        public void Shuffle()
        {
            // Use Guid to shuffle the list
            //cards = cards.OrderBy(x => Guid.NewGuid()).ToList();

            // Or use more common way to shuffle
            Random rnd = new Random();
            int count = cards.Count;

            while (count > 1)
            {
                count--;
                int rng = rnd.Next(count);
                var value = cards[rng];
                cards[rng] = cards[count];
                cards[count] = value;
            }
        }

        // Keep an index of the top card of the deck
        private int topCardIndex = 51;
        public string Deal()
        {
            // Mark sure the deck isnt empty
            if (topCardIndex > 0)
            {
                // Get card at top and return it and decrease topCardIndex
                string topCard = cards[topCardIndex];
                topCardIndex--;
                return topCard;
            }
            else
            {
                return "No more cards left in the deck!";
            }
        }

        // Method which shows user all cards in current deck
        public void DisplayDeck()
        {
            foreach (var card in cards) Console.WriteLine(card);
        }
    }
}