using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Diagram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press any key to see all of my vehicles!");
            Console.ReadKey();

            List<Automobile> vehicles = new List<Automobile>();
            vehicles.Add(new Car(120, 27, "gray", false, true, 7, true));
            vehicles.Add(new Truck(130, 32, "blue", true, true, 8, 11700, true));
            vehicles.Add(new Motorcycle(140, 22, "orange", false, false, 2.9f, true));
            vehicles.Add(new SportsCar(180, 25, "yellow", false, false, 5, false, true));
            vehicles.Add(new SUV(130, 35, "white", false, true, 8, true, 33.5f));
            vehicles.Add(new DirtBike(150, 23, "green", true, false, 2.7f, false, 0.4f));
            vehicles.Add(new SportsMotorcycle(190, 34, "purple", false, false, 2.5f, true, true));
            vehicles.Add(new TouringMotorcycle(160, 39, "black", false, true, 3f, true, 30));

            for (int i = 0; i < vehicles.Count; i++)
            {
                vehicles[i].Honk();
                vehicles[i].GoVroom();
                Console.WriteLine();
            }
        }
    }
}
 