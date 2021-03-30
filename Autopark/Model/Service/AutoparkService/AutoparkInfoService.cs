using Autopark.Entity.Class;
using Autopark.Entity.Enum;
using Autopark.Model.Extension;
using Autopark.Model.Service.GenerationService;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Autopark.Model.Service.AutoperkService
{
    public class AutoparkInfoService : AbstractService
    {
        private const int coefAutoparkCost = 5000;
        public static float autoparkSquare = 3350.50f;
        public static decimal autoparkCost = Convert.ToDecimal(autoparkSquare * coefAutoparkCost);

        private VehicleGeneration _generator;

        public AutoparkInfoService(List<Vehicle> transport) : base(transport)
        {
            _generator = new VehicleGeneration();
        }

        public override List<Vehicle> Transport { get; init; }

        /// <summary>
        /// Buy a certain number of cars
        /// </summary>
        /// <param name="vehicles">List Vehicles</param>
        /// <param name="count">Number of Vehicles</param>
        /// <param name="type">Transport type</param>
        /// <returns>Some number random vehicle</returns>
        public void BuyVehicle(int count, VehicleType type)
        {
            for (int i = 0; i < count; i++)
            {
                BuyVehicle(type);
            }
        }
        /// <summary>
        /// Buy only one vehicle
        /// </summary>
        /// <param name="vehicles">List Vehicles</param>
        /// <param name="type">Transport type</param>
        /// <returns>One random vehicle</returns>
        public void BuyVehicle(VehicleType type)
        {
            Transport.Rules()
                .TypeCharacter(type)
                .Validate();

            Transport.Add(_generator.GetMotoCar(Transport.Count + 1));
        }

        public decimal SellVehicle(int count)
        {
            decimal totalCost = 0;
            for (int i = 0; i < count; i++)
            {
                totalCost += SellVehicle();
            }
            return totalCost;
        }
        public decimal SellVehicle()
        {
            int lastVehicleIndex = Transport.Count - 1;
            decimal totalCost = Transport[lastVehicleIndex].Cost;
            Transport.RemoveAt(Transport.Count - 1);

            return totalCost;
        }

        public decimal TotalVehicleCost => Transport.Sum(x => x.Cost);

        public IOrderedEnumerable<Vehicle> SortByCost() => Transport.OrderBy(x => x.Cost);

        public IOrderedEnumerable<Vehicle> SortByWeight() => Transport.OrderBy(x => x.Weight);

        public IOrderedEnumerable<Vehicle> SortById() => Transport.OrderBy(x => x.Id);

        public IOrderedEnumerable<Vehicle> SortByTotalFuelCapacity() => Transport.OrderBy(x => x.TotalFuelCapacity);
    }
}
