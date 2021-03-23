using AutoPark.FactorMethod.BaseProduct;
using AutoPark.FactoryMethod.BaseProduct;
using AutoPark.FactoryMethod.Utils;
using AutoPark.Utils;
using System;

namespace AutoPark.FactorMethod.Products.Trucks
{
    class Zil : Truck
    {
        public Zil(int id, ColorType color, RentPeriod rentPeriod, long weight, decimal cost) 
            : base(id, color, rentPeriod, weight, cost)
        {
        }

        public override void Move()
        {
            Console.WriteLine("Zil move");
        }

        public override string ToString()
        {
            return $"{base.ToString()}, ";
        }
    }
}
