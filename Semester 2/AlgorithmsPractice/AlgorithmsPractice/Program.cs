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

            total = (h/2f) + (q/4f) + (d/10f) + (n/20f) + (p/100f);
            Console.WriteLine("$" + total.ToString("0.00"));
        }
    }
}
