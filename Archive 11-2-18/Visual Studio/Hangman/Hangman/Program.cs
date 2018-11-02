using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Hangman
{
    class Program
    {
        static void Main(string[] args)
        {

            //Creates an array of random words to choose from
            string[] WordsList = new string[25];
            WordsList[0] = "whine";
            WordsList[1] = "dank";
            WordsList[2] = "jail";
            WordsList[3] = "horses";
            WordsList[4] = "unbecoming";
            WordsList[5] = "imperfect";
            WordsList[6] = "roll";
            WordsList[7] = "bear";
            WordsList[8] = "steer";
            WordsList[9] = "homely";
            WordsList[10] = "exchange";
            WordsList[11] = "acidic";
            WordsList[12] = "thundering";
            WordsList[13] = "meat";
            WordsList[14] = "office";
            WordsList[15] = "anxious";
            WordsList[16] = "minister";
            WordsList[17] = "woke";
            WordsList[18] = "snakes";
            WordsList[19] = "giraffe";
            WordsList[20] = "hurry";
            WordsList[21] = "hysterical";
            WordsList[22] = "dislike";
            WordsList[23] = "pirate";
            WordsList[24] = "swole";

            string input = "";

            //chooses a random word in my array
            Random rand = new Random();
            int ArrayIndex = 0;
            ArrayIndex = rand.Next(25);

            //array of the correct characters in the word
            string RightWord = WordsList[ArrayIndex];

            Console.WriteLine("Welcome to Hangman!");
            Console.WriteLine("This word is " + (RightWord.Length) + " letters long.");

            List<char> guesses = new List<char>();
            int guessct = 6;
            int correct = 0;

            do
            {
                Console.WriteLine("Please enter a character to guess.");

                input = Console.ReadLine();
                guesses.Add(input[0]);
                input = input.ToLower();

                Console.WriteLine();
                
                //writes the word with the correct letters and the underscores
                //from here
                bool found = false;
                bool isValid = true;

                for (int i = 0; i < RightWord.Length; i++)
                {
                    if (guesses.Contains(RightWord[i]))
                    {
                        Console.Write(RightWord[i] + " ");
                        found = true;
                    }
                    else
                    {
                        Console.Write("_ ");
                        isValid = false;
                    }
                    if (!guesses.Contains(input[0]))
                    {
                        found = false;
                    }
                }
                Console.WriteLine();
                Console.WriteLine();
                //to here

                //checks if the character guessed was correct or not
                //from here

                if (found == false)
                {
                    Console.WriteLine("That character was not correct. Try again.");
                    Console.WriteLine("You have " + (guessct - 1) + " guesses left.");
                    guessct--;
                }

                if (found == true)
                {
                    Console.WriteLine("That character was correct!");
                    found = false;
                }

                //to here

                //tells you if you got the word or not
                //from here
                if (guessct == 0)
                {
                    Console.WriteLine("You are out of guesses. The right word was: " + RightWord);
                    Thread.Sleep(4000);
                    break;
                }
                if (isValid == true)
                {
                    Console.WriteLine("Congratulations! You guessed the word: " + RightWord);
                    Thread.Sleep(4000);
                    break;
                }
                //to here
            }
            while (input != "quit");
        }
    }
}

