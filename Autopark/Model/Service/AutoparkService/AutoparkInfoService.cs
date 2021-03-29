using Autopark.Entity.Class;
using Autopark.Entity.Enum;
using Autopark.Model.Extension;
using Autopark.Model.Service.GenerationService;
using System.Collections.Generic;
using System.Linq;

namespace Autopark.Model.Service.AutoperkService
{
    public class AutoparkInfoService : AbstractService
    {
        public float AutoparkSquare = 3350.50f;
        public decimal AutoparkCost = 30_000_000_000m;
        private readonly decimal AutoparkBank;

        private VehicleGeneration _generator;

        public AutoparkInfoService(List<Vehicle> transport) : base(transport)
        {
            _generator = new VehicleGeneration();
        }

        public AutoparkInfoService(decimal autoparkBank, List<Vehicle> transport) : base(transport)
        {
            AutoparkBank = autoparkBank;
            Transport = transport;
            _generator = new VehicleGeneration();
        }

        public AutoparkInfoService(float autoparkSquare, decimal autoparkCost, decimal autoparkBank, List<Vehicle> transport) : base(transport)
        {
            AutoparkSquare = autoparkSquare;
            AutoparkCost = autoparkCost;
            AutoparkBank = autoparkBank;
            Transport = transport;
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
        public List<Vehicle> BuyVehicle(List<Vehicle> vehicles, int count, VehicleType type)
        {
            for (int i = 1; i < count + 1; i++)
            {
                vehicles.Rules().TypeCharacter(type).Validate();
                vehicles.Add(_generator.GetMotoCar(vehicles.Count + i));
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
            vehicles.Rules()
                .TypeCharacter(type)
                .Validate();

            vehicles.Add(_generator.GetMotoCar(vehicles.Count + 1));

            return vehicles;
        }

        public decimal SellVehicle(List<Vehicle> vehicles, int count)
        {
            decimal totalCost = 0;
            for (int i = 0; i < count; i++)
            {
                int lastVehicleIndex = vehicles.Count - 1;
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

        public decimal TotalVehicleCost() => Transport.Sum(x => x.Cost);

        public void SortByCost() => Transport.OrderBy(x => x.Cost);

        public void SortByWeight() => Transport.OrderBy(x => x.Weight);

        public void SortById() => Transport.OrderBy(x => x.Id);

        public void SortByTotalFuelCapacity() => Transport.OrderBy(x => x.TotalFuelCapacity);
    }
}
