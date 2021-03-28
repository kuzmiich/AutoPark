using Autopark.Model.Enum;
using Autopark.FactoryMethod.AbstractProduct;
using Autopark.Model.Entity;
using System;

namespace Autopark.FactoryMethod.Products.MotoCars
{
    class Lamborghini : Car
    {
        public Lamborghini()
        {
        }

        public Lamborghini(int id, RentPeriod rentPeriod) : base(id, rentPeriod)
        {
        }

        public Lamborghini(int id, ColorType color, RentPeriod rentPeriod, decimal cost, long weight, int mileage, int totalFuelCapacity) : base(id, color, rentPeriod, cost, weight, mileage, totalFuelCapacity)
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
