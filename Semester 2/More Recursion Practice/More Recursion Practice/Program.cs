using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace More_Recursion_Practice
{
    class Program
    {
        static Random rand = new Random(1234);
        static void Main(string[] args)
        {
            List<int> integers = new List<int>();
            for (int i = 0; i < 1000; i++)
            {
                integers.Add(rand.Next(0, 1000));
                integers.Sort();
                bool result = SearchIntList(integers, 0);
            }
        }

        public static bool SearchIntList(List<int> integers, int n)
        {
            return SearchIntListRecursive(integers, n, 0, integers.Count - 1);
        }

        private static bool SearchIntListRecursive(List<int> integers, int n, int lowerBound, int upperBound)
        {
            if (lowerBound == upperBound)
                return false;

            int midpoint = upperBound / 2;

            if (integers[midpoint] == n)
                return true;

            if (lowerBound + 1 == upperBound || lowerBound - 1 == upperBound)
                return false;

            if (midpoint > n)
                SearchIntListRecursive(integers, n, lowerBound, midpoint);

            if (midpoint < n)
                SearchIntListRecursive(integers, n, midpoint, upperBound);

            return false;
        }
    }
}
