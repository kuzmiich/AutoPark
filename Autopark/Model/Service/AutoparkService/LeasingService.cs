using Autopark.Entity.Class;
using Autopark.Entity.Const;
using System;
using System.Collections.Generic;


namespace Autopark.Model.Service.AutoparkService
{
    public class LeasingService : ILeasingService
    {
        private const decimal DefaultRentCost = 50m;

        public LeasingService()
        {
        }

        private decimal RentCostVehicle(List<Vehicle> transport, int id)
        {
            if (transport[id]?.Brand == null)
            {
                throw new ArgumentNullException("Error, vehicle brand not found");
            }
            return transport[id].Brand switch
            {
                VehicleBrand.Lada => DefaultRentCost * VehicleCoef.Lada,
                VehicleBrand.Lamborghini => (DefaultRentCost * VehicleCoef.Lamborghini),
                VehicleBrand.Zil => (DefaultRentCost * VehicleCoef.Zil),

                _ => throw new ArgumentOutOfRangeException("Error, this vehicle brand not found")
            };
        }

        public decimal RentVehicle(List<Vehicle> transport, RentPeriod period, int vehicleId)
        {
            if (transport == null)
            {
                throw new ArgumentException("Transport can`t be null");
            }
            else if(period == null)
            {
                throw new ArgumentException("Period can`t be null");
            }
            else if (vehicleId < 0)
            {
                throw new ArgumentException("Error, invalid id.");
            }

            return RentCostVehicle(transport, vehicleId) * period.HourNumber;
        }
    }
}
