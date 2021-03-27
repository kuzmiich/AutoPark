using Autopark.FactorMethod.BaseCreator;
using Autopark.FactorMethod.CreateArea.MotoCarCreators;
using Autopark.FactorMethod.CreateArea.TruckCreators;
using Autopark.FactoryMethod.CreateArea.MotoCarCreators;
using Autopark.Utils.Entity;
using Autopark.Utils.Enums;
using Autopark.Utils.Utils.Interfaces;
using System;
using System.Collections.Generic;

namespace Autopark.Services
{
    public class Generator : IGeneratorService
    {
        #region Class Fields
        private readonly Random _random = new();

        private const int CountMotoCarCreator = 2;

        private static List<string> ProducerContries = new()
        {
            "Japan",
            "China",
            "Russia",
            "USA",
            "Canada",
            "Germany",
            "India"
        };
        private static List<ColorType> Colors = new()
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

        public Generator()
        {
        }

        private static Creator Manager { get; set; }

        public Vehicle GetTruck(int id)
        {
            int index = _random.Next(ProducerContries.Count);
            decimal cost = _random.Next(30000, 200000);
            int truckWeight = _random.Next(3000, 20000);
            int mileage = _random.Next(0, 1000);
            int totalFuelCapacity = _random.Next(50, 100);
            RentPeriod rentPeriod = new RentPeriod(_random.Next(1, 30), _random.Next(1, 4));
            Manager = new ZilCreator(ProducerContries[index]);

            return Manager.Create(id, Colors[index], rentPeriod, truckWeight, cost, mileage, totalFuelCapacity);
        }

        
        public Vehicle GetMotoCar(int id)
        {
            var index = _random.Next(ProducerContries.Count);
            RentPeriod rentPeriod = new RentPeriod(_random.Next(1, 30), _random.Next(1, 4));

            int truckWeight = _random.Next(3000, 20000);
            int mileage = _random.Next(0, 1000);
            int totalFuelCapacity = _random.Next(30, 50);

            decimal cost = 0;
            
            if (_random.Next(CountMotoCarCreator) == 0)
            {
                cost = _random.Next(10000, 25000);
                Manager = new LadaCreator(ProducerContries[index]);
            }
            else
            {
                cost = _random.Next(100000, 300000);
                Manager = new LamborghiniCreator(ProducerContries[index]);
            }
            return Manager.Create(id, Colors[index], rentPeriod, truckWeight, cost, mileage, totalFuelCapacity);
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
