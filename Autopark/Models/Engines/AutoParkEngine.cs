using Autopark.FactorMethod.BaseCreator;
using Autopark.Services;
using Autopark.Utils.Engines.Base;
using Autopark.Utils.Entity;
using Autopark.Utils.Enums;
using System.Collections.Generic;
using System.Linq;

namespace Autopark.Models.Engines
{
    public class AutoParkEngine : AbstractEngine
    {
        public float AutoparkSquare = 3350.50f;
        public decimal AutoparkCost = 30_000_000_000m;
        private decimal AutoparkBank;

        private Generator _generator;

        public AutoParkEngine(List<Vehicle> transport) : base(transport)
        {
            _generator = new Generator();
        }

        public AutoParkEngine(decimal autoparkBank, List<Vehicle> transport) : base(transport)
        {
            AutoparkBank = autoparkBank;
            Transport = transport;
            _generator = new Generator();
        }

        public AutoParkEngine(float autoparkSquare, decimal autoparkCost, decimal autoparkBank, Generator generator, List<Vehicle> transport) : base(transport)
        {
            AutoparkSquare = autoparkSquare;
            AutoparkCost = autoparkCost;
            AutoparkBank = autoparkBank;
            Transport = transport;
            _generator = new Generator();
        }

        public override List<Vehicle> Transport { get; init; }
        /// <summary>
        /// Buy a certain number of cars
        /// </summary>
        /// <param name="vehicles">List Vehicles</param>
        /// <param name="count">Number of Vehicles</param>
        /// <param name="type">Transport type</param>
        /// <returns>Some number random vehicle</returns>
        public List<Vehicle> BuyVehicle(List<Vehicle> vehicles, int count, VehicleType type)
        {
            if (type == VehicleType.MotorCar)
            {
                vehicles = _generator.GetMotoCars(count);
            }
            else if (type == VehicleType.Truck)
            {
                vehicles = _generator.GetTrucks(count);
            }
            return vehicles;
        }
        /// <summary>
        /// Buy only one vehicle
        /// </summary>
        /// <param name="vehicles">List Vehicles</param>
        /// <param name="type">Transport type</param>
        /// <returns>One random vehicle</returns>
        public List<Vehicle> BuyVehicle(List<Vehicle> vehicles, VehicleType type)
        {
            if (type == VehicleType.MotorCar)
            {
                vehicles.Add(_generator.GetMotoCar(vehicles.Count + 1));
            }
            else if (type == VehicleType.Truck)
            {
                vehicles.Add(_generator.GetTruck(vehicles.Count + 1));
            }
            return vehicles;
        }

        public decimal SellVehicle(List<Vehicle> vehicles, int count)
        {
            decimal totalCost = 0;
            int lastVehicleIndex = 0;
            for (int i = 0; i < count; i++)
            {
                lastVehicleIndex = vehicles.Count - 1;
                totalCost += vehicles[lastVehicleIndex].Cost;
                vehicles.RemoveAt(vehicles.Count - 1);
            }
            return totalCost;
        }
        public decimal SellVehicle(List<Vehicle> vehicles)
        {
            int lastVehicleIndex = vehicles.Count - 1;
            decimal totalCost = vehicles[lastVehicleIndex].Cost;
            vehicles.RemoveAt(vehicles.Count - 1);

            return totalCost;
        }

        public decimal GetTotalVehicleCost()
        {
            return Transport.Sum(x => x.Cost);
        }
        public void SortByCost()
        {
            Transport.OrderBy(x => x.Cost);
        }
        public void SortByWeight()
        {
            Transport.OrderBy(x => x.Weight);
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
