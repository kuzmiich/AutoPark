using Autopark.Entity.Class;
using Autopark.Entity.Enum;
using Autopark.Model.Extension;
using Autopark.Model.Service.GenerationService;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Autopark.Model.Service.AutoperkService
{
    public class AutoparkInfoService : IService
    {
        private const int coefAutoparkCost = 5000;
        public static float autoparkSquare = 3350.50f;
        public static decimal autoparkCost = Convert.ToDecimal(autoparkSquare * coefAutoparkCost);

        private VehicleGeneration _generator;

        public AutoparkInfoService()
        {
            _generator = new VehicleGeneration();
        }

        /// <summary>
        /// Buy a certain number of cars
        /// </summary>
        /// <param name="vehicles">List Vehicles</param>
        /// <param name="count">Number of Vehicles</param>
        /// <param name="type">Transport type</param>
        /// <returns>Some number random vehicle</returns>
        public void BuyVehicle(List<Vehicle> transport, int count, VehicleType type)
        {
            for (int i = 0; i < count; i++)
            {
                BuyVehicle(transport, type);
            }
        }

        /// <summary>
        /// Buy only one vehicle
        /// </summary>
        /// <param name="vehicles">List Vehicles</param>
        /// <param name="type">Transport type</param>
        /// <returns>One random vehicle</returns>
        public void BuyVehicle(List<Vehicle> transport, VehicleType type)
        {
            transport.Rules()
                .TypeCharacter(type)
                .Validate();

            transport.Add(_generator.GetMotoCar(transport.Count + 1));
        }

        public decimal SellVehicle(List<Vehicle> transport, int count)
        {
            decimal totalCost = 0;
            for (int i = 0; i < count; i++)
            {
                totalCost += SellVehicle(transport);
            }
            return totalCost;
        }

        public decimal SellVehicle(List<Vehicle> transport)
        {
            int lastVehicleIndex = transport.Count - 1;
            decimal totalCost = transport[lastVehicleIndex].Cost;
            transport.RemoveAt(transport.Count - 1);

            return totalCost;
        }

        public decimal TotalVehicleCost(List<Vehicle> transport)
        {
            return transport.Sum(x => x.Cost);
        }

        public IOrderedEnumerable<Vehicle> SortByCost(List<Vehicle> transport)
        {
            return transport.OrderBy(x => x.Cost);
        }

        public IOrderedEnumerable<Vehicle> SortByWeight(List<Vehicle> transport)
        {
            return transport.OrderBy(x => x.Weight);
        }

        public IOrderedEnumerable<Vehicle> SortById(List<Vehicle> transport)
        {
            return transport.OrderBy(x => x.Id);
        }

        public IOrderedEnumerable<Vehicle> SortByTotalFuelCapacity(List<Vehicle> transport)
        {
            return transport.OrderBy(x => x.TotalFuelCapacity);
        }
    }
}
