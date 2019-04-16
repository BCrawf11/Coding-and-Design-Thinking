using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stream_Reading
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rand = new Random();
            int[,] a = new int[4, 4];
            List<string> b = new List<string>();

            //same thing
            string path = @"C:\Users\166097\Documents\Junior-Year-Coding-Class\Archive 11-2-18\Visual Studio\Stream Written File\Example.txt";
            path = AppDomain.CurrentDomain.BaseDirectory + @"Example.txt";
            //

            string uinput;

            do
            {
                Console.WriteLine("Press a number based on which action you would like to perform:");
                Console.WriteLine("1. Save a random array to a file");
                Console.WriteLine("2. Load a random array from a file to List b");
                Console.WriteLine("3. Print List b");
                uinput = Console.ReadLine();

                if (uinput == "1")
                {
                    using (StreamWriter sw = new StreamWriter(path))
                    {
                        for (int i = 0; i < a.GetLength(0); i++)
                        {
                            for (int j = 0; j < a.GetLength(0); j++)
                            {
                                a[i, j] = rand.Next(0, 10);
                            }
                        }

                        for (int i = 0; i < a.GetLength(0); i++)
                        {
                            for (int j = 0; j < a.GetLength(0); j++)
                            {
                                sw.Write(a[i, j]);
                            }
                            sw.WriteLine();
                        }
                        sw.Dispose();
                    }
                }

                if (uinput == "2")
                {
                    b.Clear();
                    using (StreamReader sr = new StreamReader(path))
                    {
                        string line;
                        while ((line = sr.ReadLine()) != null)
                        {
                            b.Add(line);
                        }
                    }
                }

                if (uinput == "3")
                {
                    for (int i = 0; i < b.Count; i++)
                    {
                        Console.Write(b[i] + "");
                    }
                    Console.WriteLine();
                }
            }
            while (true);
        }
    }
}
