using AutoPark.FactorMethod.BaseCreator;
using AutoPark.FactorMethod.CreateArea.MotoCarCreators;
using AutoPark.FactorMethod.CreateArea.TruckCreators;
using AutoPark.FactoryMethod.CreateArea.MotoCarCreators;
using AutoPark.FactoryMethod.Utils;
using System;
using System.Collections.Generic;

namespace AutoPark.Utils
{
    public class Generator : IGenerator
    {
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

        public List<IMovable> GetTruck(int count)
        {
            List<IMovable> transport = new();

            for (int i = 1; i < count + 1; i++)
            {
                Creator creator = null;
                RentPeriod rentPeriod = new RentPeriod(_random.Next(1, 30), _random.Next(1, 4));
                int index = _random.Next(ProducerContries.Count);
                int truckWeight = _random.Next(3000, 20000);
                decimal cost = _random.Next(30000, 200000);

                creator = new ZilCreator(ProducerContries[index]);
                var truck = creator.Create(i, Colors[index], rentPeriod, truckWeight, cost);
                transport.Add(truck);
            }

            return transport;
        }
        public List<IMovable> GetMotoCars(int count)
        {
            List<IMovable> transport = new();
            for (int i = 1; i < count + 1; i++)
            {
                var index = _random.Next(ProducerContries.Count);

                RentPeriod rentPeriod = new RentPeriod(_random.Next(1, 30), _random.Next(1, 4));
                int truckWeight = _random.Next(3000, 20000);
                const int CountMotoCarCreator = 2;

                Creator creator;
                decimal cost;
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
                var truck = creator.Create(i, Colors[index], rentPeriod, truckWeight, cost);
                transport.Add(truck);
            }

            return transport;
        }
    }
}
