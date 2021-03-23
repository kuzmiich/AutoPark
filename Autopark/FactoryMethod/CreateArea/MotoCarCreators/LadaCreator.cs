using AutoPark.FactorMethod.BaseCreator;
using AutoPark.FactorMethod.Products.MotoCar;
using AutoPark.FactoryMethod.Utils;
using AutoPark.Utils;
using System;

namespace AutoPark.FactorMethod.CreateArea.MotoCarCreators
{
    class LadaCreator : Creator
    {
        public LadaCreator(string producerCountry) : base(producerCountry)
        {
        }

        public override string ProducerCountry { get; set; }

        public override IMovable Create(int id,
            ColorType colorType,
            RentPeriod rentDate,
            long weight,
            decimal cost)
        {
            return new Lada(id, colorType, rentDate, weight, cost);
        }
    }
}
