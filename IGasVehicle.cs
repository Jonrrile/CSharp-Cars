namespace Vehicles
{
    public interface IGasVehicle
    {
        double FuelCapacity { get; set; }
        void RefuelTank();
    }
}