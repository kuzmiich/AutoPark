using Autopark.FactorMethod.BaseCreator;
using Autopark.FactorMethod.Products.Trucks;
using Autopark.FactoryMethod.Utils;
using System;

namespace Autopark.FactorMethod.CreateArea
{
    class TruckCreator : Creator
    {
        public TruckCreator(string producerCountry) : base(producerCountry)
        {
        }

        public override string ProducerCountry { get; set; }

        public override IMovable Create(int id,
            ColorType colorType,
            DateTime rentDate,
            long weight,
            decimal cost)
        {
            return new Zil(id, colorType, rentDate, weight, cost);
        }
    }
}
