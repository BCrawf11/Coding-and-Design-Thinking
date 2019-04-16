using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //initialize an int variable for the user input
            int input = 0;
            //declare a variable of type Random
            Random rand = new Random();
            //initialize an int for the computer's chosen number
            int randnum;
            //initialize an int for the number of iterations of the do-while loop
            int guesscount = 0;
            //creates a random number using the variable of type Random
            randnum = rand.Next(0, 1000);

            //do-while input is not 1001
            do
            {      
                //increment the int for each time the loop runs
                guesscount++;
                //Prompt the user to guess a number between 0 and 1000 (1001 to give up)
                Console.WriteLine("Guess a number from 0 to 1000 (1001 to give up):");
                Console.WriteLine();
                //Read the input (a number) from the user
                input = int.Parse(Console.ReadLine());

                //if conditional that asks if the user input is between 0 and 1000
                if (input < 0 || input > 1001)
                {
                    Console.WriteLine();
                    //tells the user that their number is invalid and they need to pick a different number
                    Console.WriteLine("This is an invalid number. Please try again.");
                }

                //else if conditional that asks if the user input is less than the random number
                else if (input < randnum)
                {
                    Console.WriteLine();
                    //tells the user that the number is less than the target number
                    Console.WriteLine("This number is a little too low. Try again!");                    
                }

                //else if conditional that asks if the user input is greater than the random number
                else if (input > randnum)
                {
                    Console.WriteLine();
                    //tells the user that the number is greater than the target number
                    Console.WriteLine("This number is a little too high. Try again!");                    
                }

                //else if conditional that asks if the user input is equal to the random number
                else if (input == randnum)
                {
                    Console.WriteLine();
                    //tells the user that the number is correct
                    Console.WriteLine("You guessed the number! Well done.");
                    //tells the user that they took (int for iterations) number of guesses to get it right
                    Console.WriteLine("It took you " + guesscount + " guesses to get it right!");
                    Console.WriteLine();
                    Thread.Sleep(5000);
                    break;
                }
            }
            //do the do-while loop while the user input is not 1001
            while (input != 1001);
        }
    }
}
