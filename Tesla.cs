using System;
using System.Collections.Generic;

namespace Vehicles
{

    public class Tesla : Vehicle
    {
        public double BatteryKWh { get; set; }
        public void ChargeBattery()
        {

        }
        //This is where I override the method that is set
        //in Vehicle.cs
        public override void Drive()
        {
            Console.WriteLine("Zooooom!");
        }
    }
}