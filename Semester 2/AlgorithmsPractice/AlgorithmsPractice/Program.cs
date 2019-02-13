using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Prob1();
            //Prob2();
            //Prob3();
            //Prob4();
            Prob5();
        }

        public static void Prob1()
        {
            List<string> coins = new List<string>();
            string path1 = AppDomain.CurrentDomain.BaseDirectory + @"Prob01.in_.txt";
            float total = 0;
            float h = 0;
            float q = 0;
            float d = 0;
            float n = 0;
            float p = 0;

            using (StreamReader sr = new StreamReader(path1))
            {
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    coins.Add(line);
                }
            }

            for (int i = 0; i < coins.Count; i++)
            {
                if (coins[i].Contains("HALFDOLLAR") || coins[i].Contains("QUARTER") ||
                    coins[i].Contains("DIME") || coins[i].Contains("NICKEL") || coins[i].Contains("PENNY"))
                {
                    continue;
                }
                else
                {
                    coins.RemoveAt(i);
                }
            }

            for (int i = 0; i < coins.Count; i++)
            {
                if (coins[i].Contains("HALFDOLLAR"))
                {
                    h += float.Parse(coins[i].Substring(11));
                }

                if (coins[i].Contains("QUARTER"))
                {
                    q += float.Parse(coins[i].Substring(8));
                }

                if (coins[i].Contains("DIME"))
                {
                    d += float.Parse(coins[i].Substring(5));
                }

                if (coins[i].Contains("NICKEL"))
                {
                    n += float.Parse(coins[i].Substring(7));
                }

                if (coins[i].Contains("PENNY"))
                {
                    p += float.Parse(coins[i].Substring(6));
                }
            }

            total = (h / 2f) + (q / 4f) + (d / 10f) + (n / 20f) + (p / 100f);
            Console.WriteLine("$" + total.ToString("0.00"));
        }

        public static void Prob2()
        {
            List<List<int>> allnums = new List<List<int>>();
            List<string> lstrings = new List<string>();
            List<int> lcounts = new List<int>();

            string path1 = AppDomain.CurrentDomain.BaseDirectory + @"Prob02.in_.txt";

            bool ascending = false;
            bool descending = false;

            using (StreamReader sr = new StreamReader(path1))
            {
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    lstrings = line.Split(' ').ToList();
                    lcounts.Add(lstrings.Count);
                    List<int> nums = new List<int>();

                    for (int i = 0; i < lstrings.Count; i++)
                    {
                        int result;

                        if (int.TryParse(lstrings[i], out result) == true)
                        {
                            nums.Add(result);
                        }
                    }

                    allnums.Add(nums);
                }
            }

            for (int j = 0; j < allnums.Count; j++)
            {
                int dcount = 0;
                int acount = 0;
                bool temp = false;

                for (int k = 0; k < allnums[j].Count - 1; k++)
                {
                    if (allnums[j][k] > allnums[j][k + 1])
                    {
                        dcount++;
                        temp = false;
                    }

                    if (allnums[j][k] < allnums[j][k + 1])
                    {
                        acount++;
                        temp = true;
                    }

                    if (allnums[j][k] == allnums[j][k + 1])
                    {
                        if (temp == true)
                        {
                            acount++;
                        }

                        if (temp == false)
                        {
                            dcount++;
                        }
                    }

                    if (dcount == allnums[j].Count - 1)
                    {
                        descending = true;
                    }

                    if (acount == allnums[j].Count - 1)
                    {
                        ascending = true;
                    }
                }

                if (lcounts[j] != allnums[j].Count)
                {
                    Console.WriteLine("The input was invalid");
                    ascending = false;
                    descending = false;
                    goto End;
                }

                if (ascending == true)
                {
                    Console.WriteLine("The numbers are in ascending order");
                    ascending = false;
                }

                else if (descending == true)
                {
                    Console.WriteLine("The numbers are in descending order");
                    descending = false;
                }

                else
                    Console.WriteLine("The numbers are in random order");
                End:
                continue;
            }

        }

        public static void Prob3()
        {
            List<List<string>> AllStrings = new List<List<string>>();
            List<string> allstrings2 = new List<string>();
            List<char> key = new List<char>();

            string path1 = AppDomain.CurrentDomain.BaseDirectory + @"Prob03.in_.txt";

            using (StreamReader sr = new StreamReader(path1))
            {
                string line;
                key = sr.ReadLine().ToCharArray().ToList();

                while ((line = sr.ReadLine()) != null)
                {
                    allstrings2 = line.Split(' ').ToList();
                    AllStrings.Add(allstrings2);
                }
            }

            for (int i = 0; i < AllStrings.Count; i++)
            {
                for (int j = 0; j <  AllStrings[i].Count; j++)
                {
                    List<string> allstrings3 = new List<string>();
                    allstrings3.AddRange(AllStrings[i][j].Split('-').ToList());

                    for (int k = 0; k < allstrings3.Count; k++)
                    {
                        Console.Write(key[int.Parse(allstrings3[k]) - 1]);
                    }
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }

        public static void Prob4()
        {
            List<int> ints = new List<int>();
            int total = 1;
            string path1 = AppDomain.CurrentDomain.BaseDirectory + @"Prob04.in_.txt";

            using (StreamReader sr = new StreamReader(path1))
            {
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    ints.Add(int.Parse(line));
                }
            }

            int start = 1;

            for (int i = 0; i < ints.Count; i++)
            {
                for (int j = start - 1; j < ints[i]; j++)
                {
                    total = total * start * (j + 1);
                }
                Console.WriteLine(total);
                total = 1;
            }
        }

        public static void Prob5()
        {
            List<List<string>> tests = new List<List<string>>();
            List<int> studentNums = new List<int>();
            List<string> key = new List<string>();
            int value;

            string path1 = AppDomain.CurrentDomain.BaseDirectory + @"Prob05.in_.txt";

            using (StreamReader sr = new StreamReader(path1))
            {
                string line;
                value = int.Parse(sr.ReadLine());

                //adds the key as a separate list
                while (!(line = sr.ReadLine()).Contains("STUDENT"))
                {
                    key.Add(line.Replace(" ", ""));
                }

                if (line.Contains("STUDENT"))
                {
                    studentNums.Add(int.Parse(line.Replace("STUDENT ", "")));
                }

                while ((line = sr.ReadLine()) != null)
                {
                    List<string> questions = new List<string>();
                    questions.Add(line.Replace(" ", ""));
                }
            }

            for (int i = 0; i < tests.Count; i++)
            {
                for (int j = 0; j < tests[i].Count; j++)
                {
                    Console.Write(tests[i]);
                    Console.Write("This code is being called. " + value);
                }
            }
        }
    }
}
