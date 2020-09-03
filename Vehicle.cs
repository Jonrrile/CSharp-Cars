using System;

namespace Vehicles
{
    public class Vehicle
    {
        public string MainColor { get; set; }
        public string MaximumOccupancy { get; set; }
        public double BatterKHw { get; set; }

        public virtual void Drive()
        {
            Console.WriteLine($"The {MainColor} zooms past you? Vrooom!");
        }

    }
}