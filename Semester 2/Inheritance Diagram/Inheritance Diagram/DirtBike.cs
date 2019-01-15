using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Diagram
{
    class DirtBike : Motorcycle
    {
        protected float treadThickness;

        public DirtBike (int topSpeed, int gasMileage, string color, bool needsMtnce, bool isMuffled, float handlebarWidth, bool isLDCapable, float treadThickness)
            : base(topSpeed, gasMileage, color, needsMtnce, isMuffled, handlebarWidth, isLDCapable)
        {
            this.treadThickness = treadThickness;
        }

        public override void GoVroom()
        {
            Console.WriteLine("VRRRRRRROOOOooommm");
        }

        public override void Honk()
        {
            Console.WriteLine("Awww! This vehicle doesn't honk.");
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
            Console.WriteLine("Tread thickness: " + treadThickness + "in");
        }
    }
}
