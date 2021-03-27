using Autopark.Utils.Engines.Base;
using Autopark.Utils.Entity;
using Autopark.Utils.Enums;
using System.Collections.Generic;

namespace Autopark.Models.Engines
{
    public class LeasingEngine : AbstractEngine
    {
        public LeasingEngine(List<Vehicle> transport) : base(transport)
        {
        }

        public override List<Vehicle> Transport { get; init; }

        public decimal RentCost(RentPeriod period, decimal rentCost)
        {
            int hour = period.GetHourNumber();
            return rentCost * hour;
        }
    }
}
