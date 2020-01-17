namespace Ex_01_Vehicles
{
    public interface IVehicle
    {
        double Fuel { get; }
        double FuelConsumption { get; }
        double TankCapacity { get; }

        string Drive(double distance);
        void Refuel(double quantity);

        string ToString();


    }
}
