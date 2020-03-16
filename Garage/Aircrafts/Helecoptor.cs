using System;
using System.Collections.Generic;
using System.Text;

namespace Garage.Aircrafts
{
    class Helecoptor : Aircraft
    {
        public Helecoptor(int fuel, int passengers, VehicleColor color)
        {
            Fuel = fuel;
            Passengers = passengers;
            Color = color;
        }

        public override void Land()
        {
            Console.WriteLine("The helecoptor sets down on the landing pad.");
        }
    }

}
