using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Squares_With_a_Menu
{
    class Program
    {
        static int input;

        static void Main(string[] args)
        {
            do
            {
                input = PromptUserForInput();

                if (input == 1)
                {
                    Print3x3Square();
                }
                else if (input == 2)
                {
                    Print6x3Rectangle();
                }
                else if (input == 3)
                {
                    Print3x6Rectangle();
                }
            }
            while (input != 4);
        }
        static int PromptUserForInput()
        {
            Console.WriteLine("Enter a number corresponding to the action that you want to perform:");
            Console.WriteLine("1. Print a 3 x 3 square");
            Console.WriteLine("2. Print a 6 x 3 rectangle");
            Console.WriteLine("3. Print a 3 x 6 rectangle");
            Console.WriteLine("4. Quit the program");

            int input = int.Parse(Console.ReadLine());
            return input;
        }

        static void Print3x3Square()
        {
            //Prints a 3 x 3 Square
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("X");
                }
            }
            Console.WriteLine();
            Console.WriteLine();
        }
        static void Print6x3Rectangle()
        {
            //Prints a 6 x 3 Rectangle
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("X");
                }
            }
            Console.WriteLine();
            Console.WriteLine();
        }
        static void Print3x6Rectangle()
        {
            //Prints a 3 x 6 Rectangle
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < 6; j++)
                {
                    Console.Write("X");
                }
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}

