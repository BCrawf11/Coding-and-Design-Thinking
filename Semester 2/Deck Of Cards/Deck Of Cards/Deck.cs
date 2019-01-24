using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deck_Of_Cards
{
    class Deck
    {
        List<Card> discard = new List<Card>();
        List<Card> deck = new List<Card>();

        //constructor of my deck
        public Deck()
        {
            foreach (var face in Enum.GetValues(typeof(Face)))
            {
                foreach (var suit in Enum.GetValues(typeof(Suit)))
                {
                    deck.Add(new Card((Face)face, (Suit)suit));
                }
            }
        }

        //shuffles the deck
        public void Shuffle()
        {
            foreach (Card c in discard)
            {
                deck.Add(c);
            }
            discard.Clear();

            Random rand = new Random();
            deck = deck.OrderBy(t => rand.Next()).ToList();
        }

        public Card Draw()
        { 
            if (deck.Count == 0)
            {
                return null;
            }
            Card drawCard = deck[deck.Count - 1];
            deck.RemoveAt(deck.Count - 1);
            return drawCard;
        }

        public void Discard(Card c)
        {
            discard.Add(c);
        }

        public void PrintDeck()
        {
            for (int i = 1; i < deck.Count + 1; i++)
            {
                deck[i - 1].Print();
            }
        }

        public void PrintDiscard()
        {
            for (int i = 0; i < discard.Count; i++)
            {
                discard[i].Print();
            }
        }
    }
}
