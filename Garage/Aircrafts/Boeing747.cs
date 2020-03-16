using System;
using System.Collections.Generic;
using System.Text;

namespace Garage.Aircrafts
{
    class Boeing747 : Aircraft
    {
        public Boeing747(int fuel, int passengers, VehicleColor color)
        {
            Fuel = fuel;
            Passengers = passengers;
            Color = color;
        }

        public void ServeFood()
        {
            Console.WriteLine($"The stewardess serves food to {Passengers} passengers.");
        }

        public override void Fly(int miles)
        {
            Console.WriteLine("The plane soars through the air!");
        }
    }
}
