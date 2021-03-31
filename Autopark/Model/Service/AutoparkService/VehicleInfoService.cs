using Autopark.Entity.Class;
using System.Collections.Generic;
using System.Linq;

namespace Autopark.Model.Service.AutoperkService
{
    public class VehicleInfoService : IService
    {
        public VehicleInfoService()
        {
        }

        public long TotalWeight(List<Vehicle> transport)
        {
            return transport.Sum(x => x.Weight);
        }

        public int MaxMileage(List<Vehicle> transport)
        {
            return transport.Max(x => x.Mileage);
        }

        public double MinMileage(List<Vehicle> transport)
        {
            return transport.Min(x => x.Mileage);
        }

        public double TotalMileage(List<Vehicle> transport)
        {
            return transport.Sum(x => x.Mileage);
        }

        public int TotalFuelCapacity(List<Vehicle> transport)
        {
            return transport.Sum(x => x.TotalFuelCapacity);
        }
    }
}
