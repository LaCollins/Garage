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
