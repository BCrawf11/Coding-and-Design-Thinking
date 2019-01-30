using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQProb1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> ints = new List<string>();

            string path = @"C:\Users\166097\Documents\Junior-Year-Coding-Class\Semester 2\CodeQuest\Prob01.in.txt";

            using (StreamReader sr = new StreamReader(path))
            {
                sr.ReadLine();

                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    ints.Add(line);
                }
            }

            for (int i = 0; i < ints.Count; i++)
            {
                if (int.Parse(ints[i]) >= 70)
                {
                    Console.WriteLine("PASS");
                }
                else
                    Console.WriteLine("FAIL");
            }
        }
    }
}
