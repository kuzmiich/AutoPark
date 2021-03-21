using Autopark.FactorMethod.BaseProduct;
using Autopark.FactoryMethod.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autopark.FactoryMethod.Products.MotoCars
{
    class Lamborghini : Car
    {
        public Lamborghini(int id, ColorType color, DateTime rentDate, long weight, decimal cost) : base(id, color, rentDate, weight, cost)
        {
        }

        public override void Move()
        {
            throw new NotImplementedException();
        }
    }
}
