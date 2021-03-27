using AutoPark.FactoryMethod.BaseProduct;
using AutoPark.Utils.Entity;
using AutoPark.Utils.Enums;
using System;

namespace AutoPark.FactorMethod.Entity.Trucks
{
    class Zil : Truck
    {
        public Zil()
        {
        }

        public Zil(int id, RentPeriod rentPeriod, decimal costRent) : base(id, rentPeriod, costRent)
        {
        }

        public Zil(int id, ColorType color, decimal cost, long weight, int mileage, int totalFuelCapacity) 
            : base(id, color, cost, weight, mileage, totalFuelCapacity)
        {
        }

        public override string Brand => "Zil";

        public override void Move()
        {
            Console.WriteLine("Zil move");
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Brand - {Brand}";
        }
    }
}
