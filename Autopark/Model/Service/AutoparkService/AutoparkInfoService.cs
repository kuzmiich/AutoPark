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
        private const decimal coefAutoparkCost = 5000m;
        public static decimal autoparkSquare = 3350.5m;
        public static decimal autoparkCost = autoparkSquare * coefAutoparkCost;

        private readonly VehicleGeneration _generator;

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

            transport.Add(_generator.GetCar(transport.Count + 1));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="transport"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public static decimal SellVehicle(List<Vehicle> transport, int count)
        {
            decimal totalCost = 0;
            for (int i = 0; i < count; i++)
            {
                totalCost += SellVehicle(transport);
            }
            return totalCost;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="transport"></param>
        /// <returns></returns>
        public static decimal SellVehicle(List<Vehicle> transport)
        {
            int lastVehicleIndex = transport.Count - 1;
            decimal totalCost = transport[lastVehicleIndex].Cost;
            transport.RemoveAt(transport.Count - 1);

            return totalCost;
        }

        public static decimal TotalVehicleCost(List<Vehicle> transport)
        {
            return transport.Sum(x => x.Cost);
        }

        public static IOrderedEnumerable<Vehicle> SortByCost(List<Vehicle> transport)
        {
            return transport.OrderBy(x => x.Cost);
        }

        public static IOrderedEnumerable<Vehicle> SortByWeight(List<Vehicle> transport)
        {
            return transport.OrderBy(x => x.Weight);
        }

        public static IOrderedEnumerable<Vehicle> SortById(List<Vehicle> transport)
        {
            return transport.OrderBy(x => x.Id);
        }

        public static IOrderedEnumerable<Vehicle> SortByTotalFuelCapacity(List<Vehicle> transport)
        {
            return transport.OrderBy(x => x.TotalFuelCapacity);
        }
    }
}
