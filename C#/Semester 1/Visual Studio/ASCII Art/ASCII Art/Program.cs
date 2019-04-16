using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCII_Art
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 0;

            do
            {
                Console.WriteLine();
                Console.WriteLine("Please press a number corresponding to what action you want to perform: ");
                Console.WriteLine();
                Console.WriteLine("1. Draw a 1 x 1 square of X's");
                Console.WriteLine("2. Draw a 3 x 3 square of X's");
                Console.WriteLine("3. Draw a 5 x 4 rectangle of X's");
                Console.WriteLine("4. Draw a 5 x 5 triangle of X's with the right angle in the bottom left corner");
                Console.WriteLine("5. Draw a 5 x 5 triangle of X's with the right angle in the bottom right corner");
                Console.WriteLine("6. Draw a 5 x 3 isoceles triangle");
                Console.WriteLine("7. Draw a 5 x 5 square of X's with X's taken out from the top left to the bottom right");
                Console.WriteLine("8. Draw a 5 x 5 square of X's with X's taken out from the top right to the bottom left");
                Console.WriteLine("9. Draw a 5 x 5 square of X's with X's taken out in the shape of an X");
                Console.WriteLine("10. Draw an isoceles triangle UPSIDE DOWN");
                Console.WriteLine("11. Exit the program");
                Console.WriteLine();
                input = int.Parse(Console.ReadLine());
                Console.WriteLine();

                if (input == 1)
                {
                    for (int i = 0; i < 1; i++)
                    {
                        for (int j = 0; j < 1; j++)
                        {
                            Console.Write("X");
                        }
                        Console.WriteLine();
                    }
                }
                else if (input == 2)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            Console.Write("X");
                        }
                        Console.WriteLine();
                    }
                }
                else if (input == 3)
                {
                    for (int i = 0; i < 4; i++)
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            Console.Write("X");
                        }
                        Console.WriteLine();
                    }
                }
                else if (input == 4)
                {
                    for (int i = 1; i <= 5; i++)
                    {
                        for (int j = 0; j < i; j++)
                        {
                            Console.Write("X");
                        }
                        Console.WriteLine();
                    }
                }
                else if (input == 5)
                {
                    for (int i = 0; i <= 4; i++)
                    {
                        for (int j = 0; j <= 4; j++)
                        {
                            if (4 - j <= i)
                            {
                            Console.Write("X");
                            }
                            else 
                                Console.Write(" ");
                        }
                        Console.WriteLine();
                    }
                }
                else if (input == 6)
                {
                    for (int i = 0; i <= 2; i++)
                    {
                        for (int j = 0; j <= 7; j++)
                        {
                            if (j >= i + 3 || i <= -j + 1)
                            {
                            Console.Write(" ");
                            }
                            else
                                Console.Write("X");
                        }
                        Console.WriteLine();
                    }
                }
                else if (input == 7)
                {
                    for (int i = 1; i <= 5; i++)
                    {
                        for (int j = 1; j <= 5; j++)
                        {
                            if (j == i)
                            {
                            Console.Write(" ");
                            }
                            else
                                Console.Write("X");
                        }
                        Console.WriteLine();
                    }
                }
                else if (input == 8)
                {
                    for (int i = 1; i <= 5; i++)
                    {
                        for (int j = 5; j >= 1; j--)
                        {
                            if (j == i)
                            {
                            Console.Write(" ");
                            }
                            else
                                Console.Write("X");
                        }
                        Console.WriteLine();
                    }
                }
                else if (input == 9)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            if (j == i || 4 - j == i)
                            {
                            Console.Write(" ");
                            }
                            else
                                Console.Write("X");
                        }
                        Console.WriteLine();
                    }
                }
                else if (input == 10)
                {
                    for (int i = 2; i >= 0; i--)
                    {
                        for (int j = 4; j >= 0; j--)
                        {
                            if (j >= i + 3 || i <= -j + 1)
                            {
                            Console.Write(" ");
                            }
                            else
                                Console.Write("X");
                        }
                        Console.WriteLine();
                    }
                }
            }
            while (input != 11);
        }
    }
}