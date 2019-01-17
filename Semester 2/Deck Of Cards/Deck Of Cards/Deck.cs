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

        public void Shuffle()
        {
            foreach (var face in Enum.GetValues(typeof(Face)))
            {
                foreach (var suit in Enum.GetValues(typeof(Suit)))
                {
                    deck.Add(new Card((Face)face, (Suit)suit));
                }
            }

            Random rand = new Random();

            deck = deck.OrderBy (t => rand.Next()).ToList();
        }

        public Card Draw()
        {
            Card drawCard = deck[deck.Count - 1];
            deck.RemoveAt(deck.Count - 1);
            return drawCard;
        }

        public void Discard(Card c)
        {
            discard.Add(c);
        }
    }
}
