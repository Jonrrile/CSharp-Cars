using System;
using System.Collections.Generic;

namespace Vehicles
{

    public class Tesla : Vehicle
    {

        public void ChargeBattery()
        {

        }
        //This is where I override the method that is set
        //in Vehicle.cs
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} {Model} rushes past you hurridly! Zooooom!");
        }
        public override void Turn()
        {
            Console.WriteLine($"Turn right.");
        }
        public override void Stop()
        {
            Console.WriteLine($"Pretty sure that was a red light!");
        }
    }
}