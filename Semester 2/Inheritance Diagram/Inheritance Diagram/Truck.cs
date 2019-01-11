using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Diagram
{
    class Truck : Automobile
    {
        protected int bedLength;
        protected int towCapacity;
        protected bool isStickShift;

        public Truck(int topSpeed, int gasMileage, string color, bool needsMtnce, bool isMuffled, int bedLength, int towCapacity, bool isStickShift)
            : base ( topSpeed, gasMileage, color, needsMtnce, isMuffled)
        {
            this.bedLength = bedLength;
            this.towCapacity = towCapacity;
            this.isStickShift = isStickShift;
        }

        public override void GoVroom()
        {
            throw new NotImplementedException();
        }

        public override void Honk()
        {
            throw new NotImplementedException();
        }
    }
}
