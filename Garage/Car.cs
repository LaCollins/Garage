using System;
using System.Collections.Generic;
using System.Text;

namespace Garage
{
    class Car : Vehicle
    {

        public Car(int fuel, int passengers, VehicleColor color)
        {
            Fuel = fuel;
            Passengers = passengers;
            Color = color;
        }

        public override void Refuel(int numberOfGallons)
        {
            if (numberOfGallons <= Fuel)
            {
                Console.WriteLine($"You put {numberOfGallons} gallons of fuel in the vehicle.");
            }
            else
            {
                Console.WriteLine($"{numberOfGallons} gallons of fuel is too much for your vehicle.");
            }
        }

        public void Break()
        {
            Console.WriteLine($"You break the vehicle");
        }
    }
}
