using Autopark.Entity.Class;
using Autopark.Entity.Const;
using Autopark.Entity.Enum;
using Autopark.FactoryMethod.AbstractCreator;
using Autopark.FactoryMethod.CreateArea;
using System;
using System.Collections.Generic;

namespace Autopark.Model.Service.GenerationService
{
    public class VehicleGeneration : IGenerationService
    {
        #region Class Fields
        private readonly Random _random = new();

        private const int CountCarCreator = 2;

        private static readonly List<string> ProducerContries = new()
        {
            "Japan",
            "China",
            "Russia",
            "USA",
            "Canada",
            "Germany",
            "India"
        };
        private static readonly List<ColorType> Colors = new()
        {
            ColorType.Blue,
            ColorType.White,
            ColorType.Red,
            ColorType.Yellow,
            ColorType.Green,
            ColorType.Gold,
            ColorType.Black,
            ColorType.Silver,
        };
        #endregion

        public VehicleGeneration()
        {
        }

        private static Creator _manager;

        public Vehicle GetTruck(int id)
        {
            int produceContriesIndex = _random.Next(ProducerContries.Count);
            int colorIndex = _random.Next(Colors.Count);
            int brandIndex = _random.Next(VehicleBrand.TruckBrand.Count);
            decimal cost = _random.Next(30000, 200000);
            int truckWeight = _random.Next(5000, 50000);
            int mileage = _random.Next(0, 100000);
            int totalFuelCapacity = _random.Next(50, 150);
            RentPeriod rentPeriod = new(_random.Next(1, 30), _random.Next(1, 4));
            _manager = new TruckCreator(ProducerContries[produceContriesIndex]);

            return _manager.CreateVehicle(id, Colors[colorIndex], rentPeriod, truckWeight, cost, mileage, totalFuelCapacity, VehicleBrand.TruckBrand[brandIndex]);
        }

        
        public Vehicle GetCar(int id)
        {
            RentPeriod rentPeriod = new(_random.Next(1, 30), _random.Next(1, 4));
            int motoCarWeight = _random.Next(3000, 20000);
            int mileage = _random.Next(0, 50000);
            int totalFuelCapacity = _random.Next(30, 60);
            int produceContrieIndex = _random.Next(ProducerContries.Count);
            int colorIndex = _random.Next(Colors.Count);
            int brandIndex = _random.Next(VehicleBrand.TruckBrand.Count);

            decimal cost = 0;
            if (_random.Next(CountCarCreator) == 0)
            {
                cost = _random.Next(10000, 25000);
            }
            else
            {
                cost = _random.Next(100000, 300000);
            }

            _manager = new CarCreator(ProducerContries[produceContrieIndex]);
            return _manager.CreateVehicle(id,
                Colors[colorIndex],
                rentPeriod,
                motoCarWeight,
                cost,
                mileage,
                totalFuelCapacity,
                VehicleBrand.CarBrand[brandIndex]);
        }

        public List<Vehicle> GetCars(int count)
        {
            List<Vehicle> transport = new();
            for (int i = 1; i < count + 1; i++)
            {
                transport.Add(GetCar(i));
            }

            return transport;
        }
        public List<Vehicle> GetTrucks(int count)
        {
            List<Vehicle> transport = new();

            for (int i = 1; i < count + 1; i++)
            {
                transport.Add(GetTruck(i));
            }

            return transport;
        }
    }
}
