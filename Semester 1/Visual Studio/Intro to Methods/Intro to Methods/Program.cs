using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro_to_Methods
{
    class Program
    {
        static int input = 0;
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("*********************************************************");
                Console.WriteLine("Input a number based on which action you want to perform:");
                Console.WriteLine("1. Adds 5 and 6; prints the result");
                Console.WriteLine("2. Adds 11 and 13; prints the result");
                Console.WriteLine("3. Adds 3 and 9; prints the result");
                Console.WriteLine("4. Exit the program");
                Console.WriteLine("*********************************************************");
                Console.WriteLine();

                input = int.Parse(Console.ReadLine());

                if (input == 1)
                {
                    AddFiveAndSix();
                }
                else if (input == 2)
                {
                    AddElevenAndThirteen();
                }
                else if (input == 3)
                {
                    AddThreeAndNine();
                }
            }
            while (input != 4);
        }
        static void AddFiveAndSix()
        {
            int int1 = 5;
            int int2 = 6;
            Console.WriteLine("5 + 6 = " + (int1 + int2));
            Console.WriteLine();
        }
        static void AddElevenAndThirteen()
        {
            int int1 = 11;
            int int2 = 13;
            Console.WriteLine("11 + 13 = " + (int1 + int2));
            Console.WriteLine();
        }
        static void AddThreeAndNine()
        {
            int int1 = 3;
            int int2 = 9;
            Console.WriteLine("3 + 9 = " + (int1 + int2));
            Console.WriteLine();
        }
    }
}
