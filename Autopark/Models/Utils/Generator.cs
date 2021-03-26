using AutoPark.FactorMethod.BaseCreator;
using AutoPark.FactorMethod.CreateArea.MotoCarCreators;
using AutoPark.FactorMethod.CreateArea.TruckCreators;
using AutoPark.FactoryMethod.CreateArea.MotoCarCreators;
using AutoPark.FactoryMethod.Utils;
using AutoPark.Models.Utils.Entity;
using AutoPark.Models.Utils.Interfaces;
using System;
using System.Collections.Generic;

namespace AutoPark.Models.Utils
{
    public class Generator : IGenerator
    {
        #region Class Fields
        private readonly Random _random = new();
        private static readonly object _syncRoot = new();
        private static Generator _instance;

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

        private Generator()
        {
        }

        public static Generator GetInstance()
        {
            if (_instance == null)
            {
                lock (_syncRoot)
                {
                    if (_instance == null)
                    {
                        _instance = new Generator();
                    }
                }
            }
            return _instance;
        }

        public List<Vehicle> GetTruck(int count)
        {
            List<Vehicle> transport = new();

            for (int i = 1; i < count + 1; i++)
            {
                Creator creator = null;
                decimal cost = _random.Next(30000, 200000);
                int index = _random.Next(ProducerContries.Count);
                int truckWeight = _random.Next(3000, 20000);
                int mileage = _random.Next(0, 1000);
                int totalFuelCapacity = _random.Next(50, 100);

                creator = new ZilCreator(ProducerContries[index]);
                var truck = creator.Create(i, Colors[index], truckWeight, cost, mileage, totalFuelCapacity);
                transport.Add(truck);
            }

            return transport;
        }
        public List<Vehicle> GetMotoCars(int count)
        {
            List<Vehicle> transport = new();
            for (int i = 1; i < count + 1; i++)
            {
                var index = _random.Next(ProducerContries.Count);
                // RentPeriod rentPeriod = new RentPeriod(_random.Next(1, 30), _random.Next(1, 4));

                int truckWeight = _random.Next(3000, 20000);
                int mileage = _random.Next(0, 1000);
                int totalFuelCapacity = _random.Next(30, 50);
                Creator creator;
                decimal cost;
                const int CountMotoCarCreator = 2;
                if (_random.Next(CountMotoCarCreator) == 0)
                {
                    cost = _random.Next(10000, 25000);
                    creator = new LadaCreator(ProducerContries[index]);
                }
                else
                {
                    cost = _random.Next(100000, 300000);
                    creator = new LamborghiniCreator(ProducerContries[index]);
                }
                var truck = creator.Create(i, Colors[index], truckWeight, cost, mileage, totalFuelCapacity);
                transport.Add(truck);
            }

            return transport;
        }
    }
}
