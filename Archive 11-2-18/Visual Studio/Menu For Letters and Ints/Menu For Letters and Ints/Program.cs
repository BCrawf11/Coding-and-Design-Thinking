using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Menu_For_Letters_and_Ints
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 0;
            do
            {
                Console.WriteLine("Press a number corresponding to the action that you want to perform:");
                Console.WriteLine("1. Print the numbers corresponding to the alphabet in the ASCII table");
                Console.WriteLine("2. Print ALL characters in the ASCII table");
                Console.WriteLine("3. Qut the program");

                input = int.Parse(Console.ReadLine());

                if (input == 1)
                {
                    PrintAllCharacters();
                    Console.WriteLine();
                }
                else if (input == 2)
                {
                    PrintIntsForLetters();
                    Console.WriteLine();
                }
            }
            while (input != 3);

            Console.WriteLine("Exiting Program...");
            Thread.Sleep(1000);
        }
        static void PrintIntsForLetters()
        {
            string myString = "abcdefghijklmnopqrstuvwxyz";

            for (int i = 0; i <= 25; i++)
            {
                Console.WriteLine(myString[i] + " = " + (i + 97));
            }
        }
        static void PrintAllCharacters()
        {
            for (int i = 0; i < 13000; i++)
            {
                char myChar = (char)i;

                Console.Write(myChar);
            }
            Console.WriteLine();
        }
    }
}
