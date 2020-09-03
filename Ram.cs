using System;

namespace Vehicles
{
    public class Ram : Vehicle, IGasVehicle
    {
        public double FuelCapacity { get; set; }
        public void RefuelTank()
        {

        }
    }
}