using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Diagram
{
    class Motorcycle : Automobile
    {
        protected float handlebarWidth;
        protected bool isLDCapable;

        public Motorcycle (int topSpeed, int gasMileage, string color, bool needsMtnce, bool isMuffled, float handlebarWidth, bool isLDCapable)
            : base(topSpeed, gasMileage, color, needsMtnce, isMuffled)
        {
            this.handlebarWidth = handlebarWidth;
            this.isLDCapable = isLDCapable;
        }

        public override void GoVroom()
        {

        }

        public override void Honk()
        {

        }

        public override void PrintVehicle()
        {
            Console.WriteLine("Top speed: " + topSpeed + "mph");
            Console.WriteLine("Gas mileage: " + gasMileage + "mpg");
            Console.WriteLine("Color: " + color);
            Console.WriteLine("Needs Maintenance: " + needsMtnce.ToString());
            Console.WriteLine("Muffled: " + isMuffled.ToString());
            Console.WriteLine("Handlebar width: " + handlebarWidth + "ft");
            Console.WriteLine("Long distance capable: " + isLDCapable.ToString());
        }
    }
}