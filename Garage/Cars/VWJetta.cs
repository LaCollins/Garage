using System;
using System.Collections.Generic;
using System.Text;

namespace Garage.Cars
{
    class VWJetta : Car
    {
        public VWJetta(int fuel, int passengers, VehicleColor color)
        {
            Fuel = fuel;
            Passengers = passengers;
            Color = color;
        }

        public void HeatSeat()
        {
            Console.WriteLine("The seat warms comfortably.");
        }

        public override void Drive(int miles)
        {
            Console.WriteLine("You speed along like a crazy person.");
        }
    }
}
