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
            Console.WriteLine();
            Console.ReadKey();

            List<Automobile> vehicles = new List<Automobile>();
            vehicles.Add(new Car(120, 27, "Gray", false, true, 7, true));
            vehicles.Add(new Truck(130, 32, "Blue", true, true, 8, 11700, true));
            vehicles.Add(new Motorcycle(140, 22, "Orange", false, false, 2.9f, true));
            vehicles.Add(new SportsCar(180, 25, "Yellow", false, false, 5, false, true));
            vehicles.Add(new SUV(130, 35, "White", false, true, 8, true, 33.5f));
            vehicles.Add(new DirtBike(150, 23, "Green", true, false, 2.7f, false, 0.4f));
            vehicles.Add(new SportsMotorcycle(190, 34, "Purple", false, false, 2.5f, true, true));
            vehicles.Add(new TouringMotorcycle(160, 39, "Black", false, true, 3f, true, 30));

            for (int i = 0; i < vehicles.Count; i++)
            {
                vehicles[i].PrintVehicle();
                vehicles[i].Honk();
                vehicles[i].GoVroom();
                Console.WriteLine();
            }
        }
    }
}
 