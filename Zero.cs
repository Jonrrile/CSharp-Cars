using System;
using System.Collections.Generic;

namespace Vehicles
{

    public class Zero : Vehicle, IElectricVehicle
    {
        public int CurrentChargePercentage { get; set; }
        public double BatteryKWh { get; set; }

    }
}