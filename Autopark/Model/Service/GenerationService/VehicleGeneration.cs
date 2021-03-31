using Autopark.Entity.Class;
using Autopark.Entity.Enum;
using Autopark.FactoryMethod.AbstractCreator;
using Autopark.FactoryMethod.CreateArea.MotoCarCreators;
using Autopark.FactoryMethod.CreateArea.TruckCreators;
using Autopark.Model.Service;
using System;
using System.Collections.Generic;

namespace Autopark.Model.Service.GenerationService
{
    public class VehicleGeneration : IGenerationService
    {
        #region Class Fields
        private readonly Random _random = new();

        private const int CountMotoCarCreator = 2;

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
            int index = _random.Next(ProducerContries.Count);
            decimal cost = _random.Next(30000, 200000);
            int truckWeight = _random.Next(5000, 50000);
            int mileage = _random.Next(0, 100000);
            int totalFuelCapacity = _random.Next(50, 150);
            RentPeriod rentPeriod = new(_random.Next(1, 30), _random.Next(1, 4));
            _manager = new TruckCreator(ProducerContries[index]);

            return _manager.Create(id, Colors[index], rentPeriod, truckWeight, cost, mileage, totalFuelCapacity);
        }

        
        public Vehicle GetMotoCar(int id)
        {
            RentPeriod rentPeriod = new(_random.Next(1, 30), _random.Next(1, 4));
            int motoCarWeight = _random.Next(3000, 20000);
            int mileage = _random.Next(0, 50000);
            int totalFuelCapacity = _random.Next(30, 60);
            decimal cost = default;

            if (_random.Next(CountMotoCarCreator) == 0)
            {
                cost = _random.Next(10000, 25000);
            }
            else
            {
                cost = _random.Next(100000, 300000);
            }

            var index = _random.Next(ProducerContries.Count);
            _manager = new MotoCarCreator(ProducerContries[index]);
            return _manager.Create(id, Colors[index], rentPeriod, motoCarWeight, cost, mileage, totalFuelCapacity);
        }

        public List<Vehicle> GetMotoCars(int count)
        {
            List<Vehicle> transport = new();
            for (int i = 1; i < count + 1; i++)
            {
                transport.Add(GetMotoCar(i));
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
