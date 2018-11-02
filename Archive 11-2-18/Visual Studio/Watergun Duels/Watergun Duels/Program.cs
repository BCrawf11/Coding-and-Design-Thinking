using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Watergun_Duels
{
    class Program
    {
        static void Main(string[] args)
        {
            int maininput = 0;

            Watergun p1gun = new Watergun(1, false);
            Watergun p2gun = new Watergun(1, false);

            float p1input = 0;
            float p2input = 0;

            Console.WriteLine("Welcome to Watergun Duels!");
            Console.WriteLine("Both players have full tanks to start out the match.");
            Console.WriteLine("Enter any number to continue, or -1 to quit:");
            Console.WriteLine();
            maininput = int.Parse(Console.ReadLine());
            Console.WriteLine();

            do
            {
                if (maininput == -1)
                {
                    break;
                }

                bool p1result = p1gun.Shoot(p1input);
                bool p2result = p2gun.Shoot(p2input);

                Console.WriteLine("Player 1: Enter a percent of your tank to fire, or 0 to refill 1/4 of your tank:");
                p1input = float.Parse(Console.ReadLine());
                Console.WriteLine();

                if (p1input == 0)
                {
                    Console.WriteLine("Your gun has been refilled.");
                    Console.WriteLine();
                    p1gun.Refill();
                }
                else
                {
                    Console.WriteLine("You shot your gun!");
                    Console.WriteLine();
                    p1gun.Shoot(p1input);
                }

                Console.WriteLine("Player 2: Enter a percent of your tank to fire, or 0 to refill 1/4 of your tank:");
                p2input = float.Parse(Console.ReadLine());
                Console.WriteLine();

                if (p1input == 0)
                {
                    Console.WriteLine("Your gun has been refilled.");
                    Console.WriteLine();
                    p2gun.Refill();
                }
                else
                {
                    Console.WriteLine("You shot your gun!");
                    Console.WriteLine();
                    p2gun.Shoot(p2input);
                }

                if (p1result == false && p2result == false)
                {
                    Console.WriteLine("Nobody is wet! Keep fighting!");
                    Console.WriteLine();
                }
                if (p1result == true && p2result == false)
                {
                    Console.WriteLine("Player 1 wins!");
                    Console.WriteLine();
                }
                if (p1result == false && p2result == true)
                {
                    Console.WriteLine("Player 2 wins!");
                    Console.WriteLine();
                }
                if (p1result == true && p2result == true)
                {
                    Console.WriteLine("Both of you are wet!");
                    Console.WriteLine();
                }
            }
            while (p1input != -1 || p2input != -1);
        }
    }
}
