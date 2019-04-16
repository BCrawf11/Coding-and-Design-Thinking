using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists_AND_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> randnum = new List<int>();

            for (int i = 0; i < 10; i++)
            {
                randnum.Add(i);
                Console.Write(i);
                Console.Write(" ");
            }
            Console.WriteLine();

            for (int i = randnum.Count - 1; i > 0; i--)
            {
                randnum.RemoveAt(i);
                Console.Write(i);
                Console.Write(" ");
            }
            Console.WriteLine();

            int[] myIntArray = new int[10];

            for (int i = 0; i < myIntArray.Length; i++)
            {
                myIntArray[i] = i;
                Console.Write(i);
                Console.Write(" ");
            }
            Console.WriteLine();

            for (int i = myIntArray.Length - 1; i > 0; i--)
            {
                myIntArray[i] = 0;
                Console.Write(i);
                Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
}
