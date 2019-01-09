using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Squares_and_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Print3x3Square();
            Console.WriteLine();
            Print6x3Rectangle();
            Console.WriteLine();
            Print3x6Rectangle();
            Console.WriteLine();
            Console.WriteLine();
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
        }
    }
}
