using System;
namespace InterfaceExample.Interface
{
    public interface IVehicleInterface
    {
        void AddVehicle(int stockNumber, string Make, string Model, string Year, string Mileage);

        void DeleteVehicle(int stockNumber);

        void UpdateVehicle(int stockNumber);

        void SearchVehicleByStockNumber(int stockNumber);

        void SearchAllVehicles();
    }


    public interface Store1Database : IVehicleInterface
        {
        void AddVehicle(int stockNumber, string Make, string Model, string Year, string Mileage);

        void DeleteVehicle(int stockNumber);

        void UpdateVehicle(int stockNumber);

        void SearchVehicleByStockNumber(int stockNumber);

        void SearchAllVehicles();
    }

    public interface Store2Database : IVehicleInterface
    {
        void AddVehicle(int stockNumber, string Make, string Model, string Year, string Mileage);

        void DeleteVehicle(int stockNumber);

        void UpdateVehicle(int stockNumber);

        void SearchVehicleByStockNumber(int stockNumber);

        void SearchAllVehicles();
    }
}
