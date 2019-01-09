using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print2DArray
{
    class Program
    { 
        static void Main(string[] args)
        {
            int[,] multiDimensionalArray = new int[10, 5];
            for (int i = 0; i < multiDimensionalArray.GetLength(0); i++)
            {
                for (int j = 0; j < multiDimensionalArray.GetLength(1); j++)
                {
                    multiDimensionalArray[i, j] = i * j;
                }
            }
            Print2DArray(multiDimensionalArray);
        }

        static void Print2DArray(int [,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(" |" + array[i, j] +"| ");

                }
                Console.WriteLine();
            }
        }
    }
}
