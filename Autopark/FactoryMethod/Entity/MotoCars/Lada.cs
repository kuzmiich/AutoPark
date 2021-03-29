using Autopark.Entity.Class;
using Autopark.Entity.Enum;
using Autopark.FactoryMethod.AbstractProduct;
using System;

namespace Autopark.FactoryMethod.Entity.MotoCar
{
    class Lada : Car
    {
        public Lada()
        {
        }

        public Lada(int id, RentPeriod rentPeriod) : base(id, rentPeriod)
        {
        }

        public Lada(int id, ColorType color, RentPeriod rentPeriod, decimal cost, long weight, int mileage, int totalFuelCapacity) : base(id, color, rentPeriod, cost, weight, mileage, totalFuelCapacity)
        {
        }

        public override string Brand => "Lada";

        public override void Move()
        {
            Console.WriteLine("Lada move");
        }
        public override string ToString()
        {
            return $"{base.ToString()}, Type - {Brand}";
        }
    }
}
