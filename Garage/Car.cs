using System;
using System.Collections.Generic;
using System.Text;

namespace Garage
{
    class Car
    {
        public int Fuel { get; set; }
        public int Passengers { get; set; }
        public CarColor Color { get; set; }

        public Car(int fuel, int passengers, CarColor color)
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

    enum CarColor
    {
        Yellow,
        Red,
        Green,
        White,
        Grey,
        Blue,
        Black,
        Orange
    }
}
