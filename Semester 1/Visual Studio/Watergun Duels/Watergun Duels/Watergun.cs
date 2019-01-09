using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Watergun_Duels
{
    class Watergun
    {
        float capacity = 1;
        bool isWet = false;
        Random rand = new Random();

        public Watergun(float capacity, bool isWet)
        {
            this.capacity = capacity;
            this.isWet = isWet;
        }

        public bool Shoot(float amountFired)
        {
            if (capacity > 0)
            {
                capacity -= amountFired;
                float percentChance = (amountFired * .2f) + .2f;
                if (rand.NextDouble() < percentChance)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                Console.WriteLine("You tried to fire an empty weapon. Refill it first!!");
                return false;
            }
        }
        public void Refill()
        {
            if (capacity < 1)
            {
                capacity += .25f;
            }
            if (capacity >= 1)
            {
                capacity = 1;
            }
        }
    }
}
