using System;
using System.Collections.Generic;
using System.Text;

namespace Garage
{
    class Aircraft
    {
        public int Fuel { get; set; }
        public VehicleColor Color { get; set; }
        public int Passengers { get; set; }

        public Aircraft(int fuel, int passengers, VehicleColor color)
        {
            Fuel = fuel;
            Passengers = passengers;
            Color = color;
        }

        public void Refuel(int numberOfGallons)
        {
            if (numberOfGallons <= Fuel)
            {
                Console.WriteLine($"You put {numberOfGallons} gallons of fuel in the plane.");
            }
            else
            {
                Console.WriteLine($"{numberOfGallons} gallons of fuel is too much for your plane.")
            };
        }

        public void Fly(int miles)
        {
            Console.WriteLine($"You fly the plane {miles} miles.");
        }

        public void Land()
        {
            Console.WriteLine($"You land the plane.");
        }
    }
}
