using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roller_Coaster
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] coaster = new int[10];
            Random rand = new Random();
            int input;

            do
            {
                Console.WriteLine("Please press a number corresponding to what action you want to perform: ");
                Console.WriteLine("1. Put rider in random available seat (ride seats 10 riders).");
                Console.WriteLine("2. List available seats (1 = back, 10 = front).");
                Console.WriteLine("3. Start the ride, and print out how many people were on the ride.");
                Console.WriteLine("4. Exit the program.");
                Console.WriteLine();
                input = int.Parse(Console.ReadLine());

                if (input == 1)
                {
                    int count = 0;
                    for (int i = 0; i < coaster.Length; i++)
                    {
                        if (coaster[i] == 1)
                        {
                            count++;
                        }
                    }
                    if (count == coaster.Length)
                    {
                        Console.WriteLine("Coaster is already full, nobody can get on. :(");
                    }
                    else
                    {
                        do
                        {
                            int randseat = rand.Next(0, coaster.Length);

                            if(coaster[randseat] == 0)
                            {
                                coaster[randseat] = 1;
                                Console.WriteLine("Person added to seat " + randseat + "!");
                                Console.WriteLine();
                                break;
                            }
                        }
                        while (true);
                    }
                }
                else if (input == 2)
                {
                Console.WriteLine("Front                                Back");
                    Console.WriteLine("-----------------------------------------");
                    Console.Write("|");
                    for (int i = 0; i < coaster.Length; i++)
                    {
                        Console.Write(" " + coaster[i] + " |");
                    }
                    Console.WriteLine();
                    Console.WriteLine("-----------------------------------------");
                    Console.WriteLine();
                }
                //start the ride and print the # of people on the ride
                else if (input == 3)
                {
                    int count = 0;
                    for (int i = 0; i < coaster.Length; i++)
                    {
                        if (coaster[i] == 1)
                        {
                            count++;
                            coaster[i] = 0;
                        }
                    }

                    if (count == 1)
                    {
                        Console.WriteLine(count + " person was on this ride.");
                    }
                    else
                    Console.WriteLine(count + " people were on this ride.");
                    Console.WriteLine();
                }
                else if (input == 4)
                {
                    Console.WriteLine("Exiting application.");
                }
                else
                {
                    Console.WriteLine("You have entered an invalid option, please try again.");
                }

            }
            while (input != 4);
        }
    }
}
