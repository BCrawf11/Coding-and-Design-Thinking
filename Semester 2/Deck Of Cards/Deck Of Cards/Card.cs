using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deck_Of_Cards
{
    enum Face { Ace, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King }
    enum Suit { Clubs, Spades, Hearts, Diamonds }

    class Card
    {
        public static Dictionary<Face, int> CardValues = new Dictionary<Face, int>()
        {
            { Face.Ace, 14 },
            { Face.Two, 2 },
            { Face.Three, 3 },
            { Face.Four, 4 },
            { Face.Five, 5 },
            { Face.Six, 6 },
            { Face.Seven, 7 },
            { Face.Eight, 8 },
            { Face.Nine, 9 },
            { Face.Ten, 10 },
            { Face.Jack, 11 },
            { Face.Queen, 12 },
            { Face.King, 13 }
        };

        Face f;
        Suit s;

        public Card (Face f, Suit s)
        {
            this.f = f;
            this.s = s;
        }

        public void Print()
        {
            string msg = "| " + f.ToString() + " of " + s.ToString() + " |";

            for (int i = 0; i < msg.Length; i++)
            {
                Console.Write("-");
            }

            Console.WriteLine();
            Console.WriteLine(msg);

            for (int i = 0; i < msg.Length; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine();
        }
    }
}
