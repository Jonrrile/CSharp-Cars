using System;

namespace Vehicles
{
    public class Cessna : Vehicle, IGasVehicle
    {
        public double FuelCapacity { get; set; }
        public void RefuelTank()
        {

        }
        public override void Drive()
        {
            Console.WriteLine($"{MainColor} {Model} Dem Arby's Bois Wheel's Up! Skrt Skrt");
        }

        public override void Turn()
        {
            Console.WriteLine("Turn around every now and then...");
        }
        public override void Stop()
        {
            Console.WriteLine("Yellow means speed up!");
        }
    }
}