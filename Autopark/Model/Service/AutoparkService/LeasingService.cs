using Autopark.Entity.Class;
using Autopark.Entity.Const;
using System;
using System.Collections.Generic;

namespace Autopark.Model.Service.AutoperkService
{
    public class LeasingService : ILeasingService
    {
        private const decimal DefaultRentCost = 50m;

        public LeasingService()
        {
        }

        private decimal RentCostVehicle(List<Vehicle> transport, int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("Error, incorrect id.");
            }

            return transport[id].Brand switch
            {
                VehicleBrand.Lada => DefaultRentCost * VehicleCoef.Lada,
                VehicleBrand.Lamborghini => (DefaultRentCost * VehicleCoef.Lamborghini),
                VehicleBrand.Zil => (DefaultRentCost * VehicleCoef.Zil),

                _ => throw new ArgumentOutOfRangeException("Error, index out of range.")
            };
        }

        public decimal RentVehicle(List<Vehicle> transport, RentPeriod period, int vehicleId)
        {
            int hour = period.HourNumber;

            return RentCostVehicle(transport, vehicleId) * hour;
        }
    }
}
