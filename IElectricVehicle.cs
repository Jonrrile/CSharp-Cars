namespace Vehicles
{
    public interface IElectricVehicle
    {
        double BatteryKWh { get; set; }
        void ChargeBattery();
    }
}