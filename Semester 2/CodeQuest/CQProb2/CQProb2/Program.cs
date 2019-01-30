using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQProb2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> phrases = new List<string>();
            int count = 0;

            string path = @"C:\Users\166097\Documents\Junior-Year-Coding-Class\Semester 2\CodeQuest\Prob02.in.txt";

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
                count = 0;
                for (int j = 0; j < phrases[i].Length; j++)
                {
                    if ((int)(phrases[i])[j] == 97 || (int)(phrases[i])[j] == 101 || (int)(phrases[i])[j] == 105 ||
                        (int)(phrases[i])[j] == 111 || (int)(phrases[i])[j] == 117)
                    {
                        count++;    
                    }
                }
                Console.WriteLine(count);
            }
        }
    }
}
