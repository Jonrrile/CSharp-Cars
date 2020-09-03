using System;

namespace Vehicles
{
    public class Vehicle
    {
        public string MainColor { get; set; }
        public string Model { get; set; }
        public string MaximumOccupancy { get; set; }

        public virtual void Drive()
        {
            Console.WriteLine($"The {MainColor} {Model} zooms past you? Vrooom!");
        }

        public virtual void Turn()
        {
            Console.WriteLine("Turn left");
        }

        public virtual void Stop()
        {
            Console.WriteLine("Pretty sure that was a stop sign");
        }
    }
}