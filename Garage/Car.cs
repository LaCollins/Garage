using System;
using System.Collections.Generic;
using System.Text;

namespace Garage
{
    class Car : Vehicle
    {

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
            Console.WriteLine($"You slow the vehicle with the break pedal");
        }
    }
}
