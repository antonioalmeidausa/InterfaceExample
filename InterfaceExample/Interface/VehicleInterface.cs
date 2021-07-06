using System;
using System.Collections.Generic;

namespace InterfaceExample.Interface
{
    public interface IVehicleInterface
    {
        public Vehicle AddVehicle(int stockNumber, string Make, string Model, string Year, string Mileage);

        void DeleteVehicle(int stockNumber);

        void UpdateVehicle(int stockNumber);

        void SearchVehicleByStockNumber(int stockNumber);

        public List<Vehicle> SearchAllVehicles();
    }


    public class Store1Database : IVehicleInterface
        {
        
        public Vehicle AddVehicle(int stockNumber, string Make, string Model, string Year, string Mileage)
        {
            throw new NotImplementedException();
        }

        public void DeleteVehicle(int stockNumber)
        {
            throw new NotImplementedException();
        }

        public void UpdateVehicle(int stockNumber)
        {
            throw new NotImplementedException();
        }

        public List<Vehicle> SearchAllVehicles()
        {
            throw new NotImplementedException();
        }

        public void SearchVehicleByStockNumber(int stockNumber)
        {
            throw new NotImplementedException();
        }
    }

    public class Store2Database : IVehicleInterface
    {
        public Vehicle AddVehicle(int stockNumber, string Make, string Model, string Year, string Mileage)
        {
            throw new NotImplementedException();
        }

        public void DeleteVehicle(int stockNumber)
        {
            throw new NotImplementedException();
        }

        public void UpdateVehicle(int stockNumber)
        {
            throw new NotImplementedException();
        }

        public void SearchVehicleByStockNumber(int stockNumber)
        {
            throw new NotImplementedException();
        }

        public List<Vehicle> SearchAllVehicles()
        {
            throw new NotImplementedException();
        }

    }
}
