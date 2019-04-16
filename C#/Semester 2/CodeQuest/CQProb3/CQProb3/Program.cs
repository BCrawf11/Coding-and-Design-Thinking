using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQProb3
{
    class Program
    {
        static List<string> phrases = new List<string>();
        static string suffix = "";

        static void Main(string[] args)
        {
            string path = @"C:\Users\166097\Documents\Junior-Year-Coding-Class\Semester 2\CodeQuest\Prob03.in.txt";

            using (StreamReader sr = new StreamReader(path))
            {
                sr.ReadLine();

                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    phrases.Add(line);
                }
            }

            for (int i = 0; i < phrases.Count; i++)
            {
                phrases[i] = phrases[i].Remove((phrases[i].Length - 2), 2);
            }

            for (int i = 0; i < phrases.Count; i++)
            {
                if (phrases[i].Length == 1)
                {
                    if ((phrases[i])[phrases[i].Length - 1] == '1')
                    {
                        suffix = "st";
                        Console.WriteLine(phrases[i] + suffix);
                        goto End;
                    }

                    if ((phrases[i])[phrases[i].Length - 1] == '2')
                    {
                        suffix = "nd";
                        Console.WriteLine(phrases[i] + suffix);
                        goto End;
                    }

                    if ((phrases[i])[phrases[i].Length - 1] == '3')
                    {
                        suffix = "rd";
                        Console.WriteLine(phrases[i] + suffix);
                        goto End;
                    }
                    else
                        suffix = "th";
                        Console.WriteLine(phrases[i] + suffix);
                        goto End;
                }

                if (phrases[i].Length == 2 && (phrases[i])[0] == '1')
                {
                    suffix = "th";
                    Console.WriteLine(phrases[i] + suffix);
                    goto End;
                }

                if (phrases[i].Length >= 2)
                {
                    if ((phrases[i])[phrases[i].Length - 1] == '1')
                    {
                        suffix = "st";
                        Console.WriteLine(phrases[i] + suffix);
                        goto End;
                    }

                    if ((phrases[i])[phrases[i].Length - 1] == '2')
                    {
                        suffix = "nd";
                        Console.WriteLine(phrases[i] + suffix);
                        goto End;
                    }

                    if ((phrases[i])[phrases[i].Length - 1] == '3')
                    {
                        suffix = "rd";
                        Console.WriteLine(phrases[i] + suffix);
                        goto End;
                    }
                }

                else
                {
                    suffix = "th";
                    Console.WriteLine(phrases[i] + suffix);
                }
                End:;
            }
        }
    }
}
