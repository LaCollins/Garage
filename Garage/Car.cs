using System;
using System.Collections.Generic;
using System.Text;

namespace Garage
{
    class Car : Vehicle
    {
        public int Fuel { get; set; }
        public int Passengers { get; set; }
        public VehicleColor Color { get; set; }

        public Car(int fuel, int passengers, VehicleColor color)
        {
            Fuel = fuel;
            Passengers = passengers;
            Color = color;
        }

        public void Refuel(int numberOfGallons)
        {
            if (numberOfGallons <= Fuel)
            {
                Console.WriteLine($"You put {numberOfGallons} gallons of fuel in the vehicle.");
            }
            else
            {
                Console.WriteLine($"{numberOfGallons} gallons of fuel is too much for your vehicle.")
            };
        }

        public void Drive(int miles)
        {
            Console.WriteLine($"You drive the vehicle {miles} miles.");
        }

        public void Break()
        {
            Console.WriteLine($"You break the vehicle");
        }
    }
}
