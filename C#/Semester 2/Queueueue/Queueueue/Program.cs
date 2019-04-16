using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queueueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> myQueue = new Queue<int>();
            Queue<Currencies> myCurrencies = new Queue<Currencies>();
            Random rand = new Random();
            int input;

            for (int i = 0; i < 10; i++)
            {
                myCurrencies.EnQueue(new Currencies(rand.Next(0, 100), rand.Next(0, 100), rand.Next(0, 100)));
            }
            myCurrencies.Print();

            Console.Write("Welcome to my queue! ");

            do
            {
                Menu:
                Console.WriteLine("Press a number based on the action that you want to perform(-1 to quit).");
                Console.WriteLine("1. Add a number to the queue");
                Console.WriteLine("2. View the first element of the queue *without* deleting it");
                Console.WriteLine("3. View the first element of the queue and delete it");
                Console.WriteLine("4. Print the whole queue");
                Console.WriteLine("5. Clear the queue");
                Console.WriteLine("6. Search the queue for a number");
                Console.WriteLine();

                input = int.Parse(Console.ReadLine());

                if (input == 1)
                {
                    Console.WriteLine("Enter a number to add to the queue.");
                    int input2 = int.Parse(Console.ReadLine());

                    myQueue.EnQueue(input2);

                    Console.WriteLine("Number added.");
                    Console.WriteLine();
                }

                if (input == 2)
                {
                    int temp = myQueue.Peek();

                    if (temp == 0)
                    {
                        Console.WriteLine("Oops! You tried to peek from an empty queue!");
                        Console.WriteLine();
                        goto Menu;
                    }

                    Console.WriteLine("The first element of this queue is: " + temp);
                    Console.WriteLine();
                }

                if (input == 3)
                {
                    int temp = myQueue.DeQueue();

                    if (temp == 0)
                    {
                        Console.WriteLine("Oops! You tried to remove a number from an empty queue!");
                        Console.WriteLine();
                        goto Menu;
                    }

                    Console.WriteLine("The first element of this queue is: " + temp);
                    Console.WriteLine("This number was also removed from the queue.");
                    Console.WriteLine();
                }

                if (input == 4)
                {
                    Console.WriteLine("Here is your queue:");
                    myQueue.Print();
                    Console.WriteLine();
                }

                if (input == 5)
                {
                    Console.WriteLine("Your queue was cleared!");
                    myQueue.Clear();
                    myQueue.Print();
                    Console.WriteLine();
                }

                if (input == 6)
                {
                    Console.WriteLine("Enter a number that you would like to search for.");
                    int input3 = int.Parse(Console.ReadLine());

                    int temp = myQueue.Search(input3);
                    if (temp == Int32.MaxValue)
                    {
                        Console.WriteLine("This number was not found.");
                    }

                    Console.WriteLine("Your number was found at the " + temp + " index.");
                }

            } while (input != -1);
        }
    }
}
