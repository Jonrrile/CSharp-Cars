using System;
using System.Collections.Generic;

namespace Vehicles
{

    public class Zero : Vehicle, IElectricVehicle
    {
        public int CurrentChargePercentage { get; } = 0;
        public double BatteryKWh { get; set; }

        public void ChargeBattery()
        {

        }
    }
}