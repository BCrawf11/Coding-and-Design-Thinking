using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stream_Writing
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rand = new Random();
            int[] sArray = new int[10];
            int[,] s2DArray = new int[4, 4];

            string path = @"C:\Users\166097\Documents\Junior-Year-Coding-Class\Archive 11-2-18\Visual Studio\Stream Written File\Example.txt";
            path = AppDomain.CurrentDomain.BaseDirectory + @"Example.txt";

            using (StreamWriter sw = new StreamWriter(path, true))
            {

                for (int i = 0; i < sArray.Length; i++)
                {
                    sArray[i] = rand.Next(0, 10);
                }

                for (int i = 0; i < sArray.Length; i++)
                {
                    sw.Write(sArray[i] + "");
                }
                sw.WriteLine();
                sw.WriteLine();

                for (int i = 0; i < s2DArray.GetLength(0); i++)
                {
                    for (int j = 0; j < s2DArray.GetLength(0); j++)
                    {
                        s2DArray[i, j] = rand.Next(0, 10);
                    }
                }

                for (int i = 0; i < s2DArray.GetLength(0); i++)
                {
                    for (int j = 0; j < s2DArray.GetLength(0); j++)
                    {
                        sw.Write(s2DArray[i, j]);
                    }
                    sw.WriteLine();
                }
                sw.Dispose();
            }
        }
    }
}
