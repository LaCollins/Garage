using Garage.Aircrafts;
using Garage.Cars;
using Garage.Watercrafts;
using System;
using System.Collections.Generic;

namespace Garage
{
    class Program
    {
        public static void Main()
        {
            // Build a collection of all vehicles that fly
            var airplane = new Boeing747(200, 250, VehicleColor.Green);
            var helecopter = new Helecoptor(150, 4, VehicleColor.Black);

            List<Aircraft> aircrafts = new List<Aircraft>();
            aircrafts.Add(airplane);
            aircrafts.Add(helecopter);


            // With a single `foreach`, have each vehicle Fly()
            foreach (var aircraft in aircrafts)
            {
                aircraft.Fly(1000);
            }

            // Build a collection of all vehicles that operate on roads
            var ford = new FordFiesta(12, 5, VehicleColor.Red);
            var jetta = new VWJetta(20, 5, VehicleColor.White);

            List<Car> cars = new List<Car>();
            cars.Add(ford);
            cars.Add(jetta);

            // With a single `foreach`, have each road vehicle Drive()
            foreach (var car in cars)
            {
                car.Drive(50);
            }

            // Build a collection of all vehicles that operate on water
            var skidoo = new Skidoo(10, 1, VehicleColor.Blue);
            var skipper = new SailBoat(0, 5, VehicleColor.Orange);

            List<Watercraft> watercrafts = new List<Watercraft>();
            watercrafts.Add(skidoo);
            watercrafts.Add(skipper);

            // With a single `foreach`, have each water vehicle Drive()
            foreach (var watercraft in watercrafts)
            {
                watercraft.Drive(5);
            }

            Console.ReadKey();
        }
    }
}
