using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> L1 = new List<int>() { 8, 6, 7, 5, 3, 0, 9 };
            List<int> L2 = new List<int>() { 3, 2, 2, 8, 0, 4, 7 };
            List<int> intersect = L1.Intersect(L2).ToList();

            for (int i = 0; i < intersect.Count; i++)
            {
                Console.Write(intersect[i] + " ");
            }

            Console.WriteLine();

            List<int> l1 = new List<int>() { 8, 6, 7, 5, 3, 0, 9 };
            List<int> fiveplus = l1.Where(t => t >= 5).ToList();

            for (int i = 0; i < fiveplus.Count; i++)
            {
                Console.Write(fiveplus[i] + " ");
            }
        }
    }
}
