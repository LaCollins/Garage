using System;
using System.Collections.Generic;
using System.Text;

namespace Garage.Cars
{
    class FordFiesta : Car
    {
        public FordFiesta(int fuel, int passengers, VehicleColor color)
        {
            Fuel = fuel;
            Passengers = passengers;
            Color = color;
        }

        public void RaiseSeat()
        {
            Console.WriteLine("The seat rises a few inches.");
        }
    }
}
