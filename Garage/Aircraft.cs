using System;
using System.Collections.Generic;
using System.Text;

namespace Garage
{
    class Aircraft : Vehicle
    {
        public Aircraft(int fuel, int passengers, VehicleColor color)
        {
            Fuel = fuel;
            Passengers = passengers;
            Color = color;
        }

        public override void Refuel(int numberOfGallons)
        {
            if (numberOfGallons <= Fuel)
            {
                Console.WriteLine($"You put {numberOfGallons} gallons of fuel in the plane.");
            }
            else
            {
                Console.WriteLine($"{numberOfGallons} gallons of fuel is too much for your plane.");
            }
        }

        public void Land()
        {
            Console.WriteLine($"You land the plane.");
        }
    }
}
