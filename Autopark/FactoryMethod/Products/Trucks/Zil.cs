using Autopark.FactorMethod.BaseProduct;
using Autopark.FactoryMethod.BaseProduct;
using Autopark.FactoryMethod.Utils;
using System;

namespace Autopark.FactorMethod.Products.Trucks
{
    class Zil : Truck
    {
        public Zil(int id, ColorType color, DateTime rentDate, long weight, decimal cost) 
            : base(id, color, rentDate, weight, cost)
        {
        }
    }
}
