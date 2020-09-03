using System;

namespace Vehicles
{
    public class Cessna : Vehicle
    {
        public double BatterKHw { get; set; }

        public override void Drive()
        {
            Console.WriteLine("Dem Arby's Bois Skrt Skrt");
        }
    }
}