using System;
using System.Collections.Generic;
using System.Text;

namespace Garage.Watercrafts
{
    class SailBoat : Watercraft
    {
        public SailBoat(int fuel, int passengers, VehicleColor color)
        {
            Fuel = fuel;
            Passengers = passengers;
            Color = color;
        }

        public void UnfurlSails()
        {
            Console.WriteLine("You unfurl the sails.");
        }
    }
}
