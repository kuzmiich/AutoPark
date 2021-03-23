using AutoPark.FactorMethod.BaseProduct;
using AutoPark.FactoryMethod.Utils;
using AutoPark.Utils;
using System;

namespace AutoPark.FactoryMethod.Products.MotoCars
{
    class Lamborghini : Car
    {
        public Lamborghini(int id, ColorType color, RentPeriod rentPeriod, long weight, decimal cost) 
            : base(id, color, rentPeriod, weight, cost)
        {
        }

        public override void Move()
        {
            Console.WriteLine("Lamborghini move");
        }

        public override string ToString()
        {
            return $"{base.ToString()}, ";
        }
    }
}
