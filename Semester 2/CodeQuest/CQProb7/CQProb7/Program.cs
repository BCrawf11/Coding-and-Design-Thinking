using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CQProb7
{
    class Program
    {
        static void Main(string[] args)
        {
            List<List<string>> allstrings = new List<List<string>>();
            string path = @"C:\Users\166097\Documents\Junior-Year-Coding-Class\Semester 2\CodeQuest\Prob07.in.txt";

            using (StreamReader sr = new StreamReader(path))
            {
                int total = int.Parse(sr.ReadLine());

                for (int i = 0; i < total; i++)
                {
                    List<string> strings1 = new List<string>();
                    allstrings.Add(strings1);

                    int total2 = int.Parse(sr.ReadLine());

                    for (int j = 0; j < total2; j++)
                    {
                        strings1.Add(sr.ReadLine());
                    }
                }
            }

            string reverseString = "";
            int pcount = 0;

            List<int> fnums = new List<int>();

            for (int i = 0; i < allstrings.Count; i++)
            {
                for (int j = 0; j < allstrings[i].Count; j++)
                {
                    for (int k = allstrings[i][j].Length - 1; k >= 0; k--)
                    {
                        reverseString += allstrings[i][j][k];
                        allstrings[i][j] = allstrings[i][j].ToLower();
                    }

                    if (reverseString == allstrings[i][j])
                    {
                        pcount++;
                        reverseString = "";
                    }
                    else
                    {
                        //need to fix
                        fnums.Add(j + 1);
                        reverseString = "";
                    }
                }

                if (pcount == allstrings[i].Count)
                {
                    Console.WriteLine("True");
                    pcount = 0;
                }
                else
                    Console.Write("False - ");
                    for (int l = 0; l < fnums.Count; l++)
                    {
                        //need to fix; writes "False - 444"
                        Console.Write(fnums[i]);
                    }
            }
            Console.WriteLine();
        }
    }
}

