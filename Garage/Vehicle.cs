using System;
using System.Collections.Generic;
using System.Text;

namespace Garage
{
    class Vehicle
    {
        public int Fuel { get; set; }
        public int Passengers { get; set; }
        public VehicleColor Color { get; set; }

        public virtual void Refuel(int numberOfGallons)
        {
            Console.WriteLine($"You put {numberOfGallons} gallons of fuel in the vehicle.");
        }

        public void Drive(int miles)
        {
            Console.WriteLine($"You travel {miles} miles.");
        }
    }

    enum VehicleColor
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
