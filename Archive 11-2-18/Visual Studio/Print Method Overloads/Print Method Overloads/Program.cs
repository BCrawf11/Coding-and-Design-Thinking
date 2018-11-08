using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_Method_Overloads
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int a = rand.Next(0, 10);
            int[] array = new int[5];
            int[,] twodarray = new int[3, 4];
            int[][] jarray = new int[9][];
            string uinput = "";

            do
            {
                Console.Write("Press enter to create random numbers!! (q to quit)");
                Console.WriteLine();
                uinput = Console.ReadLine();

                if (uinput == "q")
                {
                    break;
                }

                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = rand.Next(0, 10);
                }

                for (int i = 0; i < twodarray.GetLength(0); i++)
                {
                    for (int j = 0; j < twodarray.GetLength(1); j++)
                    {
                        twodarray[i, j] = rand.Next(0, 10);
                    }
                }

                for (int i = 0; i < jarray.GetLength(0); i++)
                {
                    jarray[i] = new int[i];

                    for (int j = 0; j < jarray[i].Length; j++)
                    {
                        jarray[i][j] = rand.Next(0, 10);
                    }
                }

                Print(a);
                Print(array);
                Print(twodarray);
                Print(jarray);
                Print(Math.PI, 3);

            }
            while (uinput != "q");

        }
        static void Print(int a)
        {
            Console.WriteLine("Integer " + a);
            Console.WriteLine();
        }

        static void Print(int[] array)
        {
            Random rand = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("| " + array[i]);
            }
            Console.Write("|");
            Console.WriteLine();
            Console.WriteLine();
        }

        static void Print(int[,] array)
        {
            Random rand = new Random();

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write("| " + array[i, j]);
                }
                Console.Write("|");
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        static void Print(int[][] array)
        {
            Random rand = new Random();

            for (int i = 1; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.Write("| " + array[i][j]);
                }
                Console.Write("|");
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        static void Print(double d, int n = 2)
        {
            string num = "0.";
            string printval = d.ToString("0.##");

            if (n < 2)
            {
                n = 2;
            }

            for (int i = 0; i < n; i++)
            {
                num += "#";
            }

            Console.Write(d.ToString(num));
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
