using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Caesar_Decipherer_By_Force
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            int inc = 0;
            int count = 0;
            char myChar = ' ';

            Console.WriteLine("Enter a string for me to decrypt by brute force (quit to quit):");
            do
            {
                if (count >= 1)
                {
                    Console.WriteLine("Enter another string for me to decrypt by brute force (quit to quit):");
                }
                input = Console.ReadLine();
                input.ToLower();

                for (int i = 1; i < 26; i++)
                {
                    if (input == "quit")
                    {
                        break;
                    }

                    for (int j = 0; j < input.Length; j++)
                    {
                        inc = input[j];
                        char index = input[j];

                        if (inc < 97)
                        {
                            inc += i;

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
                            inc += i;

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
