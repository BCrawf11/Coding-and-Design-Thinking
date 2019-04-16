using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary
{
    class Program
    {
        static int n = 0;
        static int radix = 0;

        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Please enter a number to divide (0 to quit):");
                n = int.Parse(Console.ReadLine());
                Console.WriteLine();

                if (n == 0)
                {
                    break;
                }

                Console.WriteLine("Please enter a number for your base (2 for binary):");
                radix = int.Parse(Console.ReadLine());
                Console.WriteLine();

                allRadixPrint();
                Console.WriteLine();
            }
            while (true);
        }
        static void allRadixPrint()
        {
            int quotient = n / radix;
            int remainder = n - (quotient * radix);
            n = quotient;

            if (quotient != 0)
            {
                allRadixPrint();
            }

            char remainderchar = (char)('0' + remainder);

            Console.Write(remainderchar);
        }
        }
    }
