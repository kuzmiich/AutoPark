using AutoPark.FactorMethod.AbstractProduct;
using AutoPark.Utils.Entity;
using AutoPark.Utils.Enums;
using System;

namespace AutoPark.FactorMethod.Entity.MotoCar
{
    class Lada : Car
    {
        public Lada()
        {
        }

        public Lada(int id, RentPeriod rentPeriod, decimal costRent) : base(id, rentPeriod, costRent)
        {
        }

        public Lada(int id, ColorType color, decimal cost, long weight, int mileage, int totalFuelCapacity) 
            : base(id, color, cost, weight, mileage, totalFuelCapacity)
        {
        }

        public override string Brand => "Lada";

        public override void Move()
        {
            Console.WriteLine("Lada move");
        }
        public override string ToString()
        {
            return $"{base.ToString()}, Brand - {Brand}";
        }
    }
}
