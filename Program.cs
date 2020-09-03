using System;
using System.Collections.Generic;

namespace Vehicles
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero fxs = new Zero();
            Zero fx = new Zero();
            Tesla modelS = new Tesla();

            modelS.Drive();

            // modelS.ChargeBattery(2.2);

            List<Zero> electricVehicles = new List<Zero>() { fx, fxs };
        }
    }
}