using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Int_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 13000; i++)
            {
                char myChar = (char)i;

                Console.Write(myChar);
            }
            Console.WriteLine();
        }
    }
}
