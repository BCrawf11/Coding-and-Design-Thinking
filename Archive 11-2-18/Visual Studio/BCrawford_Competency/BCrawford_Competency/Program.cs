using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCrawford_Competency
{
    class Program
    {
        static void Main(string[] args)
        {
            int input;
            do
            {
                Console.WriteLine();
                Console.WriteLine("******************************************************************");
                Console.WriteLine("*Press a number corresponding to which topic you want to examine:*");
                Console.WriteLine("*1. Conditionals                                                 *");
                Console.WriteLine("*2. For Loops                                                    *");
                Console.WriteLine("*3. While Loops                                                  *");
                Console.WriteLine("*4. Arrays                                                       *");
                Console.WriteLine("*5. Lists                                                        *");
                Console.WriteLine("*-1. Exit                                                        *");
                Console.WriteLine("******************************************************************");
                Console.WriteLine();

                input = int.Parse(Console.ReadLine());
                Console.WriteLine();

                //Conditionals:
                //
                if (input == 1)
                {
                    int gradeLevel;
                    int ReadingProficiencyLevel;

                    Console.WriteLine("Enter your grade.");
                    gradeLevel = int.Parse(Console.ReadLine());
                    Console.WriteLine();

                    Console.WriteLine("Enter your reading proficiency level.");
                    ReadingProficiencyLevel = int.Parse(Console.ReadLine());
                    Console.WriteLine();

                    if (gradeLevel >= 9 && gradeLevel <= 12 && gradeLevel <= ReadingProficiencyLevel)
                    {
                        Console.WriteLine("You are in high school and can read proficiently!");
                    }
                    else if (gradeLevel >= 6 && gradeLevel <= 8 && gradeLevel <= ReadingProficiencyLevel)
                    {
                        Console.WriteLine("You are in middle school and can read proficiently!");
                    }
                    else if (gradeLevel >= 1 && gradeLevel <= 5 && gradeLevel <= ReadingProficiencyLevel)
                    {
                        Console.WriteLine("You are in elementary school and can read proficiently!");
                    }
                    else if (gradeLevel > ReadingProficiencyLevel)
                    {
                        Console.WriteLine("You cannot read proficiently.");
                    }
                }
                //

                //For Loops:
                //
                else if (input == 2)
                {
                    int countBy;
                    int countTo;

                    Console.WriteLine("Enter a number to count by:");
                    countBy = int.Parse(Console.ReadLine());

                    Console.WriteLine();
                    Console.WriteLine("Enter a number to count to:");
                    countTo = int.Parse(Console.ReadLine());
                    Console.WriteLine();

                    for (int i = 0; i <= countTo; i += countBy)
                    {
                        Console.Write(i + ", ");
                    }
                    Console.WriteLine();
                }
                //

                //While Loops:
                //
                else if (input == 3)
                {
                    int num = 1;
                    int inputSum = 0;
                    List<int> numSum = new List<int>();

                    while (num != 0)
                    {
                        Console.WriteLine("Enter a number to add to my sum:");
                        num = int.Parse(Console.ReadLine());

                        numSum.Add(num);

                        Console.WriteLine("Your new sum is: " + numSum.Sum());
                        Console.WriteLine();
                    }

                    inputSum = numSum.Sum();
                    Console.WriteLine("Your total sum is: " + inputSum);
                }
                //

                //Arrays:
                //
                else if (input == 4)
                {
                    int uInput = 0;
                    int[] intArray = new int[10];

                    for (int i = 0; i < intArray.Length; i++)
                    {
                        Console.WriteLine("Enter a number to add to my array:");
                        uInput = int.Parse(Console.ReadLine());

                        intArray[i] = uInput;

                        //add input to my array
                    }

                    Console.WriteLine();
                    Console.WriteLine("All the values in my array are full.");
                    Console.WriteLine("Here is the array:");
                    Console.WriteLine();

                    for (int i = 0; i < intArray.Length; i++)
                    {
                        Console.Write(intArray[i] + " ");
                    }
                    Console.WriteLine();
                }
                //

                //Lists:
                //
                else if (input == 5)
                {
                    string userInput = "";
                    List<string> strings = new List<string>();

                    while (userInput != "end")
                    {
                        Console.WriteLine("Enter a string to add to my list:");
                        userInput = Console.ReadLine();

                        if (userInput == "end")
                        {
                            break;
                        }
                        strings.Add(userInput);
                    }

                    Console.WriteLine();
                    Console.WriteLine("Here is the list:");

                    for (int i = 0; i < strings.Count; i++)
                    {
                        Console.Write(strings[i]);
                        Console.Write(" ");
                    }
                    Console.WriteLine();
                }
                //

                else if (input != -1)
                {
                    Console.WriteLine("That is an invalid number. Please try again.");
                }
            }
            while (input != -1);
        }
    }
}
