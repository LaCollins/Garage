using System;
using System.Collections.Generic;
using System.Text;

namespace Garage.Watercrafts
{
    class Skidoo : Watercraft
    {
        public Skidoo(int fuel, int passengers, VehicleColor color)
        {
            Fuel = fuel;
            Passengers = passengers;
            Color = color;
        }

        public void PullWaterSkier()
        {
            Console.WriteLine("You pull a water skier.");
        }
    }
}
