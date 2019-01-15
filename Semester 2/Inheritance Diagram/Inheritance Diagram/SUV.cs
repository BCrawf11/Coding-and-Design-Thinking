using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Diagram
{
    class SUV : Car
    {
        protected float trunkCapacity;

        public SUV (int topSpeed, int gasMileage, string color, bool needsMtnce, bool isMuffled, int seats, bool hasFlipSeats, float trunkCapacity) 
            : base (topSpeed, gasMileage, color, needsMtnce, isMuffled, seats, hasFlipSeats)
        {
            this.trunkCapacity = trunkCapacity;
        }

        public override void GoVroom()
        {
            Console.WriteLine("vrooommmmmm");
        }

        public override void Honk()
        {
            Console.WriteLine("merrhhp");
        }

        public override void PrintVehicle()
        {
            Console.WriteLine("Top speed: " + topSpeed + "mph");
            Console.WriteLine("Gas mileage: " + gasMileage + "mpg");
            Console.WriteLine("Color: " + color);
            Console.WriteLine("Needs Maintenance: " + needsMtnce.ToString());
            Console.WriteLine("Muffled: " + isMuffled.ToString());
            Console.WriteLine("Seats: " + seats);
            Console.WriteLine("Flip seats: " + hasFlipSeats.ToString());
            Console.WriteLine("Trunk Capacity: " + trunkCapacity + "ft^3");
        }
    }
}
