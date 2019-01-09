using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sthachke
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack mySthackhe = new Stack();
            int input = 0;

            do
            {
                Console.WriteLine("Press a number based on the action that you want to perform:");
                Console.WriteLine("0) Quit");
                Console.WriteLine("1) Push to the stack");
                Console.WriteLine("2) Pop from the stack");
                Console.WriteLine("3) Peek from the stack");
                Console.WriteLine("4) Search for a number and its index in the stack");
                Console.WriteLine("5) Print the stack");
                Console.WriteLine();
                input = int.Parse(Console.ReadLine());

                if (input == 1)
                {
                    Console.WriteLine("Enter a number that you would like to push to the stack:");
                    int input1 = int.Parse(Console.ReadLine());

                    mySthackhe.Push(input1);
                    Console.WriteLine("Number pushed.");
                    Console.WriteLine();
                }

                if (input == 2)
                {
                    if (mySthackhe.Peek() == -1)
                    {
                        Console.WriteLine("You tried to pop from an empty stack! Oh no!");
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("Your popped number is: " + mySthackhe.Pop());
                        Console.WriteLine("This number was also removed from the stack.");
                        Console.WriteLine();
                    }
                }

                if (input == 3)
                {
                    if (mySthackhe.Pop() == -1)
                    {
                        Console.WriteLine("You tried to peek from an empty stack! Oh no!");
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("Your peeked number is: " + mySthackhe.Peek());
                        Console.WriteLine();
                    }
                }

                if (input == 4)
                {
                    Console.WriteLine("Enter a number that you would like to search for:");
                    int input4 = int.Parse(Console.ReadLine());

                    if (mySthackhe.Search(input4) == -1)
                    {
                        Console.WriteLine("This number was not found.");
                        Console.WriteLine();
                    }
                    else
                        Console.WriteLine("The number " + input4 + " is in index number " + mySthackhe.Search(input4) + " in this stack.");
                        Console.WriteLine();
                }

                if (input == 5)
                {
                    Console.WriteLine("Here is your stack: ");
                    mySthackhe.Print();
                    Console.WriteLine();
                }
            }
            while (input != 0);
        }
    }
}
