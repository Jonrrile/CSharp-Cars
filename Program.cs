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

            List<IElectricVehicle> electricVehicles = new List<IElectricVehicle>()
            {
                fxs,
                modelS
            };
            Console.WriteLine("Electric Vehicles");
            foreach (IElectricVehicle ev in electricVehicles)
            {
                Console.WriteLine($"Current Battery LVL: {ev.CurrentChargePercentage}");

            }
            Console.WriteLine();
            Console.WriteLine("Charging up!");
            Console.WriteLine();

            foreach (IElectricVehicle ev in electricVehicles)
            {
                ev.ChargeBattery();
            }

        }
    }
}