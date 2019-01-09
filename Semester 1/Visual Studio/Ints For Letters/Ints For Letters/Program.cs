using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ints_For_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString = "abcdefghijklmnopqrstuvwxyz";

            for (int i = 0; i <= 25; i++)
            {
                Console.WriteLine(myString[i] + " = " + (i + 97));
            }
        }
    }
}
