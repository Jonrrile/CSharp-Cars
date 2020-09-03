using System;
using System.Collections.Generic;

namespace Vehicles
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero fxs = new Zero()
            {
                MainColor = "Sanguine",
            };
            Zero fx = new Zero()
            {
                MainColor = "Robin's Egg Blue"
            };
            Tesla modelS = new Tesla()
            {
                MainColor = "Forrest Green"
            };
            Cessna datboi = new Cessna()
            {
                MainColor = "Royal Purple"
            };

            fxs.Drive();
            modelS.Drive();
            datboi.Drive();

            // modelS.ChargeBattery(2.2);

            List<Zero> electricVehicles = new List<Zero>() { fx, fxs };
        }
    }
}