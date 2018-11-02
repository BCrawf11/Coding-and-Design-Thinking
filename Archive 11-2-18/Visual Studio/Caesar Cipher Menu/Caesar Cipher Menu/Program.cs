using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Caesar_Cipher_Menu
{
    class Program
    { 
        static void Main(string[] args)
        {
            string input;

            do
            {
                Console.WriteLine("Enter a number corresponding to the action that you want to perform (quit to quit):");
                Console.WriteLine("1. Encrypt a string of your choice");
                Console.WriteLine("2. Decrypt a string of your choice");
                Console.WriteLine("3. Decrypt a string of your choice by brute force");

                input = Console.ReadLine();
                Console.WriteLine();

                if (input == "1")
                {
                    Encrypt();
                }
                else if (input == "2")
                {
                    Decrypt();
                }
                else if (input == "3")
                {
                    BruteForce();
                }
            }
            while (input != "quit");

            Console.WriteLine("Quitting Program...");
            Thread.Sleep(3000);
        }
        static void Encrypt()
        {
            string input = "";
            int shift = 1;
            int inc = 0;
            int count = 0;
            char myChar = ' ';

            Console.WriteLine("Enter a string for me to encrypt (quit to quit):");
            do
            {
                if (count >= 1)
                {
                    Console.WriteLine("Enter another string for me to encrypt (quit to quit):");
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
        }
        static void Decrypt()
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
        }
        static void BruteForce()
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
        }
    }
}
