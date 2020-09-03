using System;

namespace Vehicles
{
    public class Cessna : Vehicle
    {

        public override void Drive()
        {
            Console.WriteLine($"{MainColor} {Model} Dem Arby's Bois Wheel's Up! Skrt Skrt");
        }
    }
}