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

        public Car(int topSpeed, int gasMileage, string color, bool needsMtnce, bool isMuffled, int seats, bool hasFlipSeats)
            : base (topSpeed, gasMileage, color, needsMtnce, isMuffled)
        {
            this.seats = seats;
            this.hasFlipSeats = hasFlipSeats;
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
