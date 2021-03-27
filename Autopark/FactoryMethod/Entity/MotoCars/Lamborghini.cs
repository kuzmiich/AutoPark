using AutoPark.FactorMethod.AbstractProduct;
using AutoPark.Utils.Entity;
using AutoPark.Utils.Enums;
using System;

namespace AutoPark.FactoryMethod.Products.MotoCars
{
    class Lamborghini : Car
    {
        public Lamborghini()
        {
        }

        public Lamborghini(int id, RentPeriod rentPeriod, decimal costRent) : base(id, rentPeriod, costRent)
        {
        }

        public Lamborghini(int id, ColorType color, decimal cost, long weight, int mileage, int totalFuelCapacity) : base(id, color, cost, weight, mileage, totalFuelCapacity)
        {
        }

        public override string Brand => "Lamborghini";

        public override void Move()
        {
            Console.WriteLine("Lamborghini move");
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Brand - {Brand}";
        }
    }
}
