using Autopark.Entity.Class;
using System.Collections.Generic;

namespace Autopark.Model.Service.AutoparkService
{
    public class ParkingService : AbstractService
    {
        public readonly int Gain;
        private const int _parkingSpaceCost = 5;
        public ParkingService(List<Vehicle> transport) : base(transport)
        {

        }

        public override List<Vehicle> Transport { get; init; }


        public decimal ParkVehicle(RentPeriod period)
        {
            int hour = period.GetHourNumber();
            return _parkingSpaceCost * hour;
        }
    }
}
