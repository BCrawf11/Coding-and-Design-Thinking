using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Palindrome_FINDER
{
    class Program
    {
        static void Main(string[] args)
        {
            string pString = "";
            string input = "";

            do
            {
                Console.WriteLine();
                Console.WriteLine("Enter a number corresponding to the action that you want to perform:");
                Console.WriteLine("1. Test a whole passage at once to find if it is a palindrome.");
                Console.WriteLine("2. Test a whole passage to find ALL the palindromes");
                Console.WriteLine("\"quit\" to quit");
                Console.WriteLine();
                input = Console.ReadLine();

                if (input == "1")
                {
                    string String;

                    String reverseString = "";

                    Console.WriteLine("Input any string (quit to quit).");
                    Console.WriteLine();
                    String = Console.ReadLine();
                    String = String.Replace(" ", String.Empty);
                    String = String.ToLower();

                    Console.WriteLine();

                    //concatenates the string typed in reverse order.
                    for (int i = String.Length - 1; i >= 0; i--)
                    {
                        reverseString += String[i];
                    }

                    //breaks out of the loop once "quit" is typed.
                    if (String == "quit")
                    {
                        break;
                    }
                    //tests the string and tells you if it is a palindrome or not.
                    if (reverseString == String)
                    {
                        Console.WriteLine("This string is a palindrome! :)");
                    }
                    else
                    {
                        Console.WriteLine("This string is not a palindrome. :(");
                    }
                }

                else if (input == "2")
                {

                    int count = 0;
                    List<string> palindromes = new List<string>();

                    //asks the user for a passage for the program to check.
                    Console.WriteLine("Input any passage to search for palindromes.");
                    Console.WriteLine();
                    pString = Console.ReadLine();

                    pString = pString.Replace(" ", String.Empty);
                    pString = pString.ToLower();

                    //finds the ODD palindromes in the passage, and adds them to my list ("palindromes").
                    //from here
                    for (int i = 0; i < pString.Length; i++)
                    {
                        for (int j = 0; j < (i + 1); j++)
                        {                        
                            if (i == pString.Length - 1)
                            {
                                break;
                            }
                            if ((pString[i + j]) == (pString[i - j]))
                            {
                                if (j >= 1)
                                {
                                    palindromes.Add(pString.Substring(i-j, (j * 2 + 1)));
                                    count++;
                                }
                            }
                            else
                                break;
                        }
                    }
                    //to here

                    if (count >= 1)
                    {
                        Console.WriteLine();
                        Console.WriteLine("There are " + count + " palindromes in this passage!");
                        Console.WriteLine("These are the palindromes:");
                        Console.WriteLine();

                        //writes the palindromes that the program found
                        for (int i = 0; i < palindromes.Count; i++)
                        {
                          Console.WriteLine(palindromes[i]);
                        }
                    }
                    else if (count == 0)
                    {
                        Console.WriteLine();
                        Console.WriteLine("There are 0 palindromes in this passage. :(");
                    }
                }

                else if (input != "quit")
                {
                    Console.WriteLine("That is an invalid entry. Please try again.");
                }
            }
            while (input != "quit");
        }
    }
}
