using Autopark.Model.Enum;
using Autopark.FactoryMethod.BaseProduct;
using Autopark.Model.Entity;
using System;

namespace Autopark.FactoryMethod.Entity.Trucks
{
    class Zil : Truck
    {
        public Zil()
        {
        }

        public Zil(int id, RentPeriod rentPeriod) : base(id, rentPeriod)
        {
        }

        public Zil(int id, ColorType color, RentPeriod rentPeriod, decimal cost, long weight, int mileage, int totalFuelCapacity) 
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
