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
            Cessna datboi = new Cessna();

            fxs.Drive();
            modelS.Drive();
            datboi.Drive();

            // modelS.ChargeBattery(2.2);

            List<Zero> electricVehicles = new List<Zero>() { fx, fxs };
        }
    }
}