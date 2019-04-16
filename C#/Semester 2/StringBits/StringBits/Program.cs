using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBits
{
    class Program
    {
        static void Main(string[] args)
        {
            string ex = "hello";
            string newstring = "";

            for (int i = 0; i < ex.Length; i += 2)
            {
                newstring += ex[i];
            }

            Console.WriteLine(newstring);
        }
    }
}
