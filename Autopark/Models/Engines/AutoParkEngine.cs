using AutoPark.Models.Utils.Entity;
using System.Collections.Generic;
using System.Linq;

namespace AutoPark.Models.Engine
{
    public class AutoParkEngine
    {
        public AutoParkEngine(List<Vehicle> transport)
        {
            Transport = transport;
        }

        public List<Vehicle> Transport { get; init; }

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
        public decimal GetCommonCost()
        {
            return Transport.Sum(x => x.Cost);
        }
        public float GetTotalWeight()
        {
            return Transport.Sum(x => x.Weight);
        }

        public void SortByCost()
        {
            Transport.OrderBy(x => x.Cost);
        }
        public void SortByCostRent()
        {
            Transport.OrderBy(x => x.CostRent);
        }
        public void SortByTotalFuelCapacity()
        {
            Transport.OrderBy(x => x.TotalFuelCapacity);
        }

    }
}
