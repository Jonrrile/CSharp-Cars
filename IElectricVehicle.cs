namespace Vehicles
{
    public interface IElectricVehicle
    {
        int CurrentChargePercentage { get; }
        double BatteryKWh { get; set; }
        void ChargeBattery();

    }
}