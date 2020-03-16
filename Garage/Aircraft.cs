using System;
using System.Collections.Generic;
using System.Text;

namespace Garage
{
    class Aircraft : Vehicle
    {
        public override void Refuel(int numberOfGallons)
        {
            if (numberOfGallons <= Fuel)
            {
                Console.WriteLine($"You put {numberOfGallons} gallons of fuel in the plane.");
            }
            else
            {
                Console.WriteLine($"{numberOfGallons} gallons of fuel is too much for your plane.");
            }
        }

        public virtual void Fly(int miles)
        {
            Console.WriteLine($"You fly {miles} miles.");
        }

        public virtual void Land()
        {
            Console.WriteLine($"You land the plane.");
        }
    }
}
