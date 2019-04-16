using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Diagram
{
    class Car : Automobile
    {
        protected int seats;
        protected bool hasFlipSeats;

        public Car (int topSpeed, int gasMileage, string color, bool needsMtnce, bool isMuffled, int seats, bool hasFlipSeats)
            : base (topSpeed, gasMileage, color, needsMtnce, isMuffled)
        {
            this.seats = seats;
            this.hasFlipSeats = hasFlipSeats;
        }

        public override void GoVroom()
        {
            Console.WriteLine("vrooommmmmmm");
        }

        public override void Honk()
        {
            Console.WriteLine("bbeeeEEEEPP");
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
        }
    }
}
