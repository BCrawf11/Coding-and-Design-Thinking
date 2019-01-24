using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deck_Of_Cards
{
    class Program
    {
        static string p1input = "";
        static string p2input = "";
        static List<Card> hand1 = new List<Card>();
        static List<Card> hand2 = new List<Card>();

        static Deck deck = new Deck();

        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Welcome to Spoons! Enter quit at any time *after drawing cards* to quit.");
                Console.WriteLine("Each player starts with 4 cards.");
                Console.WriteLine("The goal of the game is to get four cards with the same face by discarding and drawing to get new cards.");
                Console.WriteLine("The first player to do this wins. Remember, don't show the other player your hand!");
                Console.WriteLine();
                Console.WriteLine("Player 1, press any key to play!");
                Console.ReadKey();
                Console.WriteLine();
                Console.WriteLine("Player 2, press any key to play!");
                Console.ReadKey();
                Console.WriteLine();

                deck.Shuffle();

                do
                {
                    Console.WriteLine("Player 1, enter \"draw\" to draw 4 cards and start the game (Don't let player 2 see your hand).");
                    p1input = Console.ReadLine();

                    if (p1input == "draw")
                    {
                        //This will add the drawn card to the hand1 list, then print
                        //the most recent card drawn.
                        Console.WriteLine("You drew:");
                        hand1.Add(deck.Draw());
                        (hand1[hand1.Count - 1]).Print();
                        hand1.Add(deck.Draw());
                        (hand1[hand1.Count - 1]).Print();
                        hand1.Add(deck.Draw());
                        (hand1[hand1.Count - 1]).Print();
                        hand1.Add(deck.Draw());
                        (hand1[hand1.Count - 1]).Print();
                        //
                    }
                    else
                        Console.WriteLine("Oops! This input was not recognized. Please try again.");
                }
                while (p1input != "draw");

                do
                {
                    Console.WriteLine("Player 2, enter \"draw\" to draw 4 cards and start the game (Don't let player 1 see your hand).");
                    p2input = Console.ReadLine();

                    if (p2input == "quit")
                    {
                        goto Quit;
                    }

                    if (p2input == "draw")
                    {
                        //This will add the drawn card to the hand1 list, then print
                        //the most recent card drawn.
                        Console.WriteLine("You drew:");
                        hand2.Add(deck.Draw());
                        (hand2[hand2.Count - 1]).Print();
                        hand2.Add(deck.Draw());
                        (hand2[hand2.Count - 1]).Print();
                        hand2.Add(deck.Draw());
                        (hand2[hand2.Count - 1]).Print();
                        hand2.Add(deck.Draw());
                        (hand2[hand2.Count - 1]).Print();
                        //
                    }
                    else
                        Console.WriteLine("Oops! This input was not recognized. Please try again.");
                }
                while (p2input != "draw");

                for (int i = 0; i < 22; i++)
                {
                    if ((hand1[0].face) == (hand1[1].face) && (hand1[1].face) == (hand1[2].face) && (hand1[2].face) == (hand1[3].face))
                    {
                        goto P1Wins;
                    }

                    if ((hand2[0].face) == (hand2[1].face) && (hand2[1].face) == (hand2[2].face) && (hand2[2].face) == (hand2[3].face))
                    {
                        goto P2Wins;
                    }

                    P1Discard();
                    if (p1input == "quit")
                    {
                        goto Quit;
                    }

                    P2Discard();
                    if (p2input == "quit")
                    {
                        goto Quit;
                    }

                    P1Draw();
                    if (p1input == "quit")
                    {
                        goto Quit;
                    }

                    P2Draw();
                    if (p2input == "quit")
                    {
                        goto Quit;
                    }
                }
                deck.Shuffle();
            }
            while (p1input != "quit" && p2input != "quit");

        P1Wins:
            Console.WriteLine("Woohoo! Player 1 wins!");
            goto End;
        P2Wins:
            Console.WriteLine("Woohoo! Player 2 wins!");
        Quit:
            Console.WriteLine("Awww! You quit. See you next time!");
        End:
            Console.WriteLine();
        }

        static void P1Discard()
        {
            Console.WriteLine("Player 1, pick a card to discard to the discard pile. (1-4 = first to last)");
            p1input = Console.ReadLine();

            int index = int.Parse(p1input) - 1;
            deck.Discard(hand1[index]);
            hand1.RemoveAt(index);

            Console.WriteLine("Here is your new hand:");

            for (int i = 0; i < hand1.Count; i++)
            {
                (hand1[i]).Print();
            }
        }

        static void P2Discard()
        {
            Console.WriteLine("Player 2, pick a card to discard to the discard pile. (1-4 = first to last)");
            p2input = Console.ReadLine();

            int index = int.Parse(p2input) - 1;
            deck.Discard(hand2[index]);
            hand2.RemoveAt(index);

            Console.WriteLine("Here is your new hand:");

            for (int i = 0; i < hand2.Count; i++)
            {
                (hand2[i]).Print();
            }
        }

        static void P1Draw()
        {
            do
            {
                Console.WriteLine("Player 1, enter \"draw\" to draw another card (Don't let player 2 see your hand).");
                p1input = Console.ReadLine();

                if (p1input == "draw")
                {
                    hand1.Add(deck.Draw());

                    Console.WriteLine("Here is your hand:");
                    for (int i = 0; i < hand1.Count; i++)
                    {
                        hand1[i].Print();
                    }
                }
                else if (p1input == "quit")
                {
                    p1input = "quit";
                    break;
                }
                else
                    Console.WriteLine("Oops! This input was not recognized. Please try again.");
            }
            while (p1input != "draw");
        }

        static void P2Draw()
        {
            do
            {
                Console.WriteLine("Player 2, enter \"draw\" to draw another card (Don't let player 1 see your hand).");
                p2input = Console.ReadLine();

                if (p2input == "draw")
                {
                    hand2.Add(deck.Draw());

                    Console.WriteLine("Here is your hand:");
                    for (int i = 0; i < hand2.Count; i++)
                    {
                        hand2[i].Print();
                    }
                }
                else if (p2input == "quit")
                {
                    p2input = "quit";
                    break;
                }
                else
                    Console.WriteLine("Oops! This input was not recognized. Please try again.");
            }
            while (p2input != "draw");
        }
    }
}
