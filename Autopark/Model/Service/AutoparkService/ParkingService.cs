﻿using Autopark.Entity.Class;
using System.Collections.Generic;

namespace Autopark.Model.Service.AutoparkService
{
    public class ParkingService : IParkingService
    {
        private const int _parkingSpaceCost = 5;

        public decimal ParkVehicle(RentPeriod period)
        {
            if (period is null)
            {
                throw new System.ArgumentNullException($"{nameof(period)} cannot be null");
            }

            int hour = period.HourNumber;

            return _parkingSpaceCost * hour;
        }
    }
}
