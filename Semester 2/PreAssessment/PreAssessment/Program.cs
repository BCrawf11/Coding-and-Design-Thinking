using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreAssessment
{
    class Program
    {
        static void Main(string[] args)
        {
            int maininput = 0;
            Console.WriteLine("Welcome to Brodie's pre-assessment!");

            do
            {
                Console.WriteLine("Here are Brodie's 9 options:");
                Console.WriteLine("1. Print \"Hello World\"");
                Console.WriteLine("2. Add two numbers together of your choice");
                Console.WriteLine("3. Calculate the area of a circle with radius [fill in the blank]");
                Console.WriteLine("4. Calculate the area of a triangle with 3 sides of your choice");
                Console.WriteLine("5. Draw a square of \"X\"'s with a width of [fill in the blank]");
                Console.WriteLine("6. Draw a *hollow* square of \"X\"'s with a width of [fill in the blank]");
                Console.WriteLine("7. Swap the value of two integers of your choice");
                Console.WriteLine("8. Reverse a string of your choice");
                Console.WriteLine("9. Exit the program");
                Console.WriteLine();
                maininput = int.Parse(Console.ReadLine());
                Console.WriteLine();

                switch (maininput)
                {
                    case 1:
                        PrintHelloWorld();
                        Console.WriteLine();
                        break;

                    case 2:
                        AddTwoNumbers();
                        Console.WriteLine();
                        break;

                    case 3:
                        AreaOfCircle();
                        Console.WriteLine();
                        break;

                    case 4:
                        AreaOfTriangle();
                        Console.WriteLine();
                        break;

                    case 5:
                        DrawSquare();
                        Console.WriteLine();
                        break;

                    case 6:
                        DrawHollowSquare();
                        Console.WriteLine();
                        break;

                    case 7:
                        SwapValues();
                        Console.WriteLine();
                        break;

                    case 8:
                        ReverseString();
                        Console.WriteLine();
                        break;

                    case 9:
                        Console.WriteLine("To exit the program,");
                        break;
                }
            }
            while (maininput != 9);
        }

        static void PrintHelloWorld()
        {
            Console.WriteLine("Hello World");
        }

        static void AddTwoNumbers()
        {
            Console.WriteLine("Enter the 1st number you want to add:");
            int int1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the 2nd number you want to add:");
            int int2 = int.Parse(Console.ReadLine());
            Console.WriteLine("The sum of these two numbers is: " + (int1 + int2));
        }

        static void AreaOfCircle()
        {
            Console.WriteLine("Enter the radius of the circle that you would like to find the area of:");
            float r = float.Parse(Console.ReadLine());
            float a = (float)Math.Round(Math.Pow(r, 2) * Math.PI, 4);
            Console.WriteLine("The area of this circle is about: " + a);
        }

        static void AreaOfTriangle()
        {
            Console.WriteLine("Enter the length of the 1st side:");
            float s1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the length of the 2nd side:");
            float s2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the length of the 3rd side:");
            float s3 = float.Parse(Console.ReadLine());

            double p = (s1 + s2 + s3) / 2;
            float a = (float)Math.Round(Math.Sqrt(p*(p-s1)*(p-s2)*(p-s3)), 4);
            Console.WriteLine("The area of this triangle is about: " + a);
        }

        static void DrawSquare()
        {
            Console.WriteLine("Enter the length/width of your square:");
            int w = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Here is your square:");

            for (int i = 0; i < w; i++)
            {
                for (int j = 0; j < w; j++)
                {
                    Console.Write("X");
                }
                Console.WriteLine();
            }
        }

        static void DrawHollowSquare()
        {
            Console.WriteLine("Enter the length/width of your hollow square:");
            int w = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Here is your hollow square:");

            for (int i = 0; i < w; i++)
            {
                for (int j = 0; j < w; j++)
                {
                    if (i == 0 || j == 0 || i == w - 1 || j == w - 1)
                    {
                        Console.Write("X");
                    }
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
        }

        static void SwapValues()
        {
            Console.WriteLine("Enter the 1st number to be swapped:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the 2nd number to be swapped:");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine(num1 + ", " + num2 + " is now:");

            int temp = num2;
            num2 = num1;
            num1 = temp;

            Console.WriteLine(num1 + ", " + num2);
        }

        static void ReverseString()
        {
            Console.WriteLine("Enter the string you want reversed:");
            string msg = Console.ReadLine();
            string gsm = "";

            for (int i = msg.Length - 1; i >= 0; i--)
            {
                gsm += msg[i];
            }

            Console.WriteLine("Your reversed string is: " + gsm);
        }
    }
}
