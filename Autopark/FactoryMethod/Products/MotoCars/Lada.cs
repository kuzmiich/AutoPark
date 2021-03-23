using AutoPark.FactorMethod.BaseProduct;
using AutoPark.FactoryMethod.Utils;
using AutoPark.Utils;
using System;

namespace AutoPark.FactorMethod.Products.MotoCar
{
    class Lada : Car
    {
        public Lada(int id, ColorType color, RentPeriod rentDate, long weight, decimal cost)
            : base(id, color, rentDate, weight, cost)
        {
        }

        public override void Move()
        {
            Console.WriteLine("Lada move");
        }
        public override string ToString()
        {
            return $"{base.ToString()}, ";
        }
    }
}
