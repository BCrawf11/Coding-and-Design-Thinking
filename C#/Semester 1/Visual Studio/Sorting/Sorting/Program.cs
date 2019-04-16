using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class Program
    {
        static int[] array = new int[10];
        static Random rand = new Random();

        static void Main(string[] args)
        {
            Console.WriteLine("Unsorted Array:");

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(0, 10);
                Console.Write(array[i]);
            }

            SortLeastToGreatest();
            SortGreatestToLeast();
        }
        static void SortLeastToGreatest()
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (i == 0 && j == 0)
                    {
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("Sorted Array From Least to Greatest:");
                    }

                    if ((array[i] > array[j]) && (j > i))
                    {
                        int temp = array[j];
                        array[j] = array[i];
                        array[i] = temp;
                    }
                }
                Console.Write(array[i]);
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        static void SortGreatestToLeast()
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (i == 0 && j == 0)
                    {
                        Console.WriteLine("Sorted Array From Greatest to Least:");
                    }

                    if ((array[i] < array[j]) && (j > i))
                    {
                        int temp = array[j];
                        array[j] = array[i];
                        array[i] = temp;
                    }
                }
                Console.Write(array[i]);
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
