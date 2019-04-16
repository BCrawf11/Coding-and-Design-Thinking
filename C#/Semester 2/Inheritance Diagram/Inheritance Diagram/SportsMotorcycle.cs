using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Diagram
{
    class SportsMotorcycle : Motorcycle
    {
        protected bool hasWindshield;

        public SportsMotorcycle (int topSpeed, int gasMileage, string color, bool needsMtnce, bool isMuffled, float handlebarWidth, bool isLDCapable, bool hasWindshield)
            : base(topSpeed, gasMileage, color, needsMtnce, isMuffled, handlebarWidth, isLDCapable)
        {
            this.hasWindshield = hasWindshield;
        }

        public override void GoVroom()
        {
            Console.WriteLine("vvvvvrrRRROOOOMMMMMMMBOOMBOOMboomboomboomboom");
        }

        public override void Honk()
        {
            Console.WriteLine("beeeepppBEEEEEEEPPPPP");
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
            Console.WriteLine("Has windshield: " + hasWindshield.ToString());
        }
    }
}
