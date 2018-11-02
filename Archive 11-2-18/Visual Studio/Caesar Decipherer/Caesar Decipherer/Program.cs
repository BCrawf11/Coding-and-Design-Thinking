using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Caesar_Decipherer
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            int shift = -1;
            int inc = 0;
            int count = 0;
            char myChar = ' ';

            Console.WriteLine("Enter a string for me to decrypt (quit to quit):");
            do
            {
                if (count >= 1)
                {
                    Console.WriteLine("Enter another string for me to decrypt (quit to quit):");
                }
                input = Console.ReadLine();

                for (int i = 0; i < input.Length; i++)
                {
                    if (input == "quit")
                    {
                        break;
                    }

                    inc = input[i];
                    char index = input[i];

                    if (inc < 97)
                    {
                        inc += shift;

                        if (inc > 90)
                        {
                            inc = inc - 26;
                        }
                        else if (inc < 65)
                        {
                            inc = inc + 26;
                        }

                        myChar = (char)inc;

                        if (index == ' ')
                        {
                            myChar = ' ';
                        }
                        else if (index == '.')
                        {
                            myChar = '.';
                        }
                        else if (index == ',')
                        {
                            myChar = ',';
                        }
                        else if (index == '!')
                        {
                            myChar = '!';
                        }
                        Console.Write(myChar);
                    }
                    else
                    {
                        inc += shift;

                        if (inc > 122)
                        {
                            inc = inc - 26;
                        }
                        else if (inc < 97)
                        {
                            inc = inc + 26;
                        }

                        myChar = (char)inc;

                        if (index == ' ')
                        {
                            myChar = ' ';
                        }
                        else if (index == '.')
                        {
                            myChar = '.';
                        }
                        else if (index == ',')
                        {
                            myChar = ',';
                        }
                        else if (index == '!')
                        {
                            myChar = '!';
                        }
                        Console.Write(myChar);
                    }
                }
                Console.WriteLine();
                count++;
            }
            while (input != "quit");

            Console.WriteLine("Quitting Program...");
            Thread.Sleep(3000);
        }
    }
}
