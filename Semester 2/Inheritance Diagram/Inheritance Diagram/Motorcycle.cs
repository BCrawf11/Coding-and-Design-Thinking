using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Diagram
{
    class Motorcycle : Automobile
    {
        protected int handlebarWidth;
        protected bool isLDCapable;

        public Motorcycle(int topSpeed, int gasMileage, string color, bool needsMtnce, bool isMuffled, int handlebarWidth, bool isLDCapable)
            : base (topSpeed, gasMileage, color, needsMtnce, isMuffled)
        {
            this.handlebarWidth = handlebarWidth;
            this.isLDCapable = isLDCapable;
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
