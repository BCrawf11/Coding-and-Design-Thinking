using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myIntArray = new int[10];

            for (int i = 0; i < myIntArray.Length; i++)
            {
                myIntArray[i] = i;
            }

            List<int> myIntList = new List<int>();

            for (int i = 0; i < 10; i++)
            {
                myIntList.Add(i);
            }

            int[] myIntArray2 = new int[10];

            int input = 0;
            int index = 0;

            while (input != 11)
            {
                Console.WriteLine("Please enter a number (11 to exit): ");
                input = int.Parse(Console.ReadLine());
                myIntArray2[index] = input;
                index++;

                if (index == 10)
                {
                    index = 0;
                }
            }
        }
    }
}
