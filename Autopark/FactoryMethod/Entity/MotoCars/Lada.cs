using Autopark.FactorMethod.AbstractProduct;
using Autopark.Utils.Entity;
using Autopark.Utils.Enums;
using System;

namespace Autopark.FactorMethod.Entity.MotoCar
{
    class Lada : Car
    {
        public Lada()
        {
        }

        public Lada(int id, RentPeriod rentPeriod, decimal rentCost) : base(id, rentPeriod)
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
            return $"{base.ToString()}, Brand - {Brand}";
        }
    }
}
