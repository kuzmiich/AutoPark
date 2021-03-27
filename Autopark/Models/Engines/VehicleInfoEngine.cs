using Autopark.Utils.Engines.Base;
using Autopark.Utils.Entity;
using System.Collections.Generic;
using System.Linq;

namespace Autopark.Models.Engines
{
    public class VehicleInfoEngine : AbstractEngine
    {
        public VehicleInfoEngine(List<Vehicle> transport) : base(transport)
        {
        }

        public override List<Vehicle> Transport { get; init; }

        public long GetTotalWeight()
        {
            return Transport.Sum(x => x.Weight);
        }
        public int GetMaxMileage()
        {
            return Transport.Max(x => x.Mileage);
        }
        public double GetMinMileage()
        {
            return Transport.Min(x => x.Mileage);
        }
        public double GetTotalMileage()
        {
            return Transport.Sum(x => x.Mileage);
        }
        public int GetCommonFuelCapacity()
        {
            return Transport.Sum(x => x.TotalFuelCapacity);
        }
    }
}
