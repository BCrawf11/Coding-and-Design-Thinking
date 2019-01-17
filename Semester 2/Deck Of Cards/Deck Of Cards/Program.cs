using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deck_Of_Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            string p1input = "";
            string p2input = "";
            List<Card> hand1 = new List<Card>();
            List<Card> hand2 = new List<Card>();

            Deck deck = new Deck();

            do
            {
                Console.WriteLine("Welcome to Spoons! Enter quit at any time to quit.");
                Console.WriteLine("Player 1, press any key to play!");
                Console.ReadKey();
                Console.WriteLine();
                Console.WriteLine("Player 2, press any key to play!");
                Console.ReadKey();
                Console.WriteLine();

                deck.Shuffle();

                Console.WriteLine("Player 1, enter \"draw\" to draw 4 cards and start the game.");
                p1input = Console.ReadLine();

                if (p1input == "draw")
                {
                    Console.WriteLine("You drew:");
                    hand1.Add(deck.Draw());
                    (hand1[hand1.Count - 1]).Print();
                    hand1.Add(deck.Draw());
                    (hand1[hand1.Count - 1]).Print();
                    hand1.Add(deck.Draw());
                    (hand1[hand1.Count - 1]).Print();
                    hand1.Add(deck.Draw());
                    (hand1[hand1.Count - 1]).Print();
                }

                Console.WriteLine("Player 2, enter \"draw\" to draw 4 cards and start the game.");
                p2input = Console.ReadLine();

                if (p1input == "draw")
                {
                    Console.WriteLine("You drew:");
                    hand2.Add(deck.Draw());
                    (hand2[hand2.Count - 1]).Print();
                    hand2.Add(deck.Draw());
                    (hand2[hand2.Count - 1]).Print();
                    hand2.Add(deck.Draw());
                    (hand2[hand2.Count - 1]).Print();
                    hand2.Add(deck.Draw());
                    (hand2[hand2.Count - 1]).Print();
                }

                Console.WriteLine("Player 1, pick a card to discard to the discard pile. (Enter 1-4)");
                p1input = Console.ReadLine();

                int index = int.Parse(p1input);
                //Need to fix so that it discards from hand1, not the deck
                deck.Discard(hand1[index]);
                //
                hand1.RemoveAt(index);
            }
            while (p1input != "quit" && p2input != "quit");
        }
    }
}
