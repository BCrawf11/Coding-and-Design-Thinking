using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            string String;

            do
            {
                string reverseString = "";

                Console.WriteLine("Input any string (quit to quit).");
                Console.WriteLine();
                String = Console.ReadLine();
                String = String.Replace(" ", String.Empty);
                String = String.ToLower();

                Console.WriteLine();

                //concatenates the string typed in reverse order.
                for (int i = String.Length - 1; i >= 0; i--)
                {
                    reverseString += String[i];
                }

                //breaks out of the loop once "quit" is typed.
                if (String == "quit")
                {
                    break;
                }
                //tests the string and tells you if it is a palindrome or not.
                if (reverseString == String)
                {
                    Console.WriteLine("This string is a palindrome! :)");
                }
                else
                {
                    Console.WriteLine("This string is not a palindrome. :(");
                }
                Console.WriteLine();
            }
            while (String != "quit");
        }
    }
}