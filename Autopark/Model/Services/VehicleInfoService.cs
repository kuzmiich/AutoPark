using Autopark.Model.Services.Base;
using Autopark.Model.Entity;
using System.Collections.Generic;
using System.Linq;

namespace Autopark.Model.Services
{
    public class VehicleInfoService : AbstractService
    {
        public VehicleInfoService(List<Vehicle> transport) : base(transport)
        {
        }

        public override List<Vehicle> Transport { get; init; }

        public long TotalWeight => Transport.Sum(x => x.Weight);

        public int MaxMileage => Transport.Max(x => x.Mileage);

        public double MinMileage => Transport.Min(x => x.Mileage);

        public double TotalMileage => Transport.Sum(x => x.Mileage);

        public int GetCommonFuelCapacity => Transport.Sum(x => x.TotalFuelCapacity);
    }
}
