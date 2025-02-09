﻿using Autopark.Entity.Class;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Autopark.Model.Service.AutoparkService
{
    public class VehicleInfoService : IVehicleInfoService
    {
        public VehicleInfoService()
        {
        }

        public long TotalWeight(IEnumerable<Vehicle> vehicles)
        {
            if (vehicles is null)
            {
                throw new ArgumentNullException("Error, vehicles is null");
            }
            return vehicles.Sum(x => x.Weight);
        }

        public int MaxMileage(IEnumerable<Vehicle> vehicles)
        {
            if (vehicles is null)
            {
                throw new ArgumentNullException("Error, vehicles is null");
            }
            return vehicles.Max(x => x.Mileage);
        }

        public double MinMileage(IEnumerable<Vehicle> vehicles)
        {
            if (vehicles is null)
            {
                throw new ArgumentNullException("Error, vehicles is null");
            }
            return vehicles.Min(x => x.Mileage);
        }

        public double TotalMileage(IEnumerable<Vehicle> vehicles)
        {
            if (vehicles is null)
            {
                throw new ArgumentNullException("Error, vehicles is null");
            }
            return vehicles.Sum(x => x.Mileage);
        }

        public int TotalFuelCapacity(IEnumerable<Vehicle> vehicles)
        {
            if (vehicles is null)
            {
                throw new ArgumentNullException("Error, vehicles is null");
            }
            return vehicles.Sum(x => x.TotalFuelCapacity);
        }
    }
}
