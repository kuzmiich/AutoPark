using Autopark.Entity.Class;
using Autopark.Entity.Enum;
using System;
using System.Collections.Generic;

namespace Autopark.Model.Service.AutoperkService
{
    public class LeasingService : AbstractService
    {
        private const int DefaultRentCost = 50;

        public LeasingService(List<Vehicle> transport) : base(transport)
        {
        }

        public override List<Vehicle> Transport { get; init; }

        private decimal RentCostVehicle(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("Error, incorrect id.");
            }

            return Transport[id].Brand switch
            {
                "Lada" => (decimal)(DefaultRentCost * VehicleCoef.Lada),
                "Lamborghini" => (decimal)(DefaultRentCost * VehicleCoef.Lamborghini),
                "Zil" => (decimal)(DefaultRentCost * VehicleCoef.Zil),

                _ => throw new ArgumentOutOfRangeException("Error, index out of range.")
            };
        }

        public decimal RentVehicle(RentPeriod period, int vehicleId)
        {
            int hour = period.GetHourNumber();
            return RentCostVehicle(vehicleId) * hour;
        }
    }
}
