using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Diagram
{
    class TouringMotorcycle : Motorcycle
    {
        protected int pannierSize;

        public TouringMotorcycle (int topSpeed, int gasMileage, string color, bool needsMtnce, bool isMuffled, float handlebarWidth, bool isLDCapable, int pannierSize)
            : base(topSpeed, gasMileage, color, needsMtnce, isMuffled, handlebarWidth, isLDCapable)
        {
            this.pannierSize = pannierSize;
        }

        public override void GoVroom()
        {
            Console.WriteLine("vvrrrRROOOMMMMMMMMMMMMMM");
        }

        public override void Honk()
        {
            Console.WriteLine("beeeEEEEEEEPPPPPPPPPP");
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
            Console.WriteLine("Pannier size: " + pannierSize + "L");
        }
    }
}
