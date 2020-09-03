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
                Model = "fxs"
            };
            Zero fx = new Zero()
            {
                MainColor = "Robin's Egg Blue",
                Model = "fx"
            };
            Tesla modelS = new Tesla()
            {
                MainColor = "Forrest Green",
                Model = "modelS"
            };
            Cessna datboi = new Cessna()
            {
                MainColor = "Royal Purple",
                Model = "datboi"
            };

            fxs.Drive();
            fxs.Turn();
            fxs.Stop();
            Console.WriteLine();
            modelS.Drive();
            modelS.Turn();
            modelS.Stop();
            Console.WriteLine();
            datboi.Drive();
            datboi.Turn();
            datboi.Stop();

            // modelS.ChargeBattery(2.2);

            List<Zero> electricVehicles = new List<Zero>() { fx, fxs };
        }
    }
}