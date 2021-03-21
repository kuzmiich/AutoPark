using Autopark.FactorMethod.BaseCreator;
using Autopark.FactorMethod.Products.MotoCar;
using Autopark.FactoryMethod.Utils;
using System;

namespace Autopark.FactorMethod.CreateArea
{
    class MotoCarCreator : Creator
    {
        public MotoCarCreator(string producerCountry) : base(producerCountry)
        {
        }

        public override string ProducerCountry { get; set; }

        public override IMovable Create(int id,
            ColorType colorType,
            DateTime rentDate,
            long weight,
            decimal cost)
        {
            return new Lada(id, colorType, rentDate, weight, cost);
        }
    }
}
