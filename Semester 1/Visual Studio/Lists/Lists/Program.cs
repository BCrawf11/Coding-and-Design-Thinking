using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            int input;

            List<int> randnum = new List<int>();

            for (int i = 0; i < 10; i++)
            {
                randnum.Add(i);
                Console.Write(randnum[i]);
                Console.Write(" ");
            }
            Console.WriteLine();

            do
            {
                Console.WriteLine("Enter a number that you would like to add to the list (0 to exit):");
                Console.WriteLine();
                input = int.Parse(Console.ReadLine());

                randnum.Add(input);

                for (int rn = 0; rn < randnum.Count; rn++)
                {
                    Console.Write(randnum[rn]);
                    Console.Write(" ");
                }

                Console.WriteLine();
                Console.WriteLine();
            }
            while (input != 0);
        }
    }
}
