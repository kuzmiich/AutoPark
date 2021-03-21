using Autopark.FactorMethod.BaseProduct;
using Autopark.FactoryMethod.Utils;
using System;

namespace Autopark.FactorMethod.Products.MotoCar
{
    class Lada : Car
    {
        public Lada(int id, ColorType color, DateTime rentDate, long weight, decimal cost) 
            : base(id, color, rentDate, weight, cost)
        {
        }

        public override void Move()
        {
            throw new NotImplementedException();
        }
    }
}
