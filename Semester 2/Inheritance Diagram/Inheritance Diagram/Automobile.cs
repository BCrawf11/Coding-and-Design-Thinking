using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Diagram
{
    abstract class Automobile
    {
        protected int topSpeed;
        protected int gasMileage;
        protected string color;
        protected bool needsMtnce;
        protected bool isMuffled;

        public Automobile(int topSpeed, int gasMileage, string color, bool needsMtnce, bool isMuffled)
        {
            this.topSpeed = topSpeed;
            this.gasMileage = gasMileage;
            this.color = color;
            this.needsMtnce = needsMtnce;
            this.isMuffled = isMuffled;
        }

        public abstract void GoVroom();

        public abstract void Honk();
    }
}
