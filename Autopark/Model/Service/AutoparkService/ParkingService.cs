using Autopark.Entity.Class;
using System.Collections.Generic;

namespace Autopark.Model.Service.AutoparkService
{
    public class ParkingService : IService
    {
        public readonly int Gain;
        private const int _parkingSpaceCost = 5;


        public decimal ParkVehicle(RentPeriod period)
        {
            int hour = period.GetHourNumber();
            return _parkingSpaceCost * hour;
        }
    }
}
