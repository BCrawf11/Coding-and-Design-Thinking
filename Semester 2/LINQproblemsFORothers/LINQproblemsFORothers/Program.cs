using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQproblemsFORothers
{
    class Program
    {
        static void Main(string[] args)
        {
            //problem done without LINQ
            string[] students = new string[] { "Brodie", "Dylan", "Joe", "Tommy", "Hunter", "Gertrude" };
            string longestName = "Brodie";

            for (int i = 0; i < students.Length; i++)
            {
                if (students[i].Length > longestName.Length)
                {
                    longestName = students[i];
                }
            }

            //problem done with LINQ
            string[] students1 = new string[] { "Brodie", "Dylan", "Joe", "Tommy", "Hunter", "Gertrude" };
            string longestName1 = students1.Aggregate("Brodie", (longest, next) => next.Length > longest.Length ? next : longest);

            Console.WriteLine("The longest name in this array is: " + longestName);
        }
    }
}
