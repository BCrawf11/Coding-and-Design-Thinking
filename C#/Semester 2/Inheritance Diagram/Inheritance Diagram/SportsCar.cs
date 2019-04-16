using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Diagram
{
    class SportsCar : Car
    {
        protected bool hasSunRoof;

        public SportsCar (int topSpeed, int gasMileage, string color, bool needsMtnce, bool isMuffled, int seats, bool hasFlipSeats, bool hasSunRoof)
            : base(topSpeed, gasMileage, color, needsMtnce, isMuffled, seats, hasFlipSeats)
        {
            this.hasSunRoof = hasSunRoof;
        }

        public override void GoVroom()
        {
            Console.WriteLine("vrrrOOOOOOMMMMMMMMMMmmmmmm");
        }

        public override void Honk()
        {
            Console.WriteLine("bllhhHEEEPPP");
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
            Console.WriteLine("Sun roof: " + hasSunRoof.ToString());
        }
    }
}
