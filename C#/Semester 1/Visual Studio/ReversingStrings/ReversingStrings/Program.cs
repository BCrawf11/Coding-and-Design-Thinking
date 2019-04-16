using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            string String;

            do
            {
                Console.WriteLine("Input any string (quit to quit).");
                String = Console.ReadLine();

                for (int i = String.Length - 1; i >= 0; i--)
                {
                    Console.Write(String[i]);
                }
                Console.WriteLine();

            }
            while (String != "quit");
        }
    }
}
