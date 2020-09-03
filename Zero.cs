using System;

namespace Vehicles
{

    public class Zero : Vehicle
    {
        public double BatteryKHw { get; set; }

        public void ChargeBattery()
        {
            Console.WriteLine($"Your Tesla now charged to {this.BatteryKHw} KHw.");
        }
    }
}