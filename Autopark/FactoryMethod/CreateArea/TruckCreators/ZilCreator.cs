using AutoPark.FactorMethod.BaseCreator;
using AutoPark.FactorMethod.Products.Trucks;
using AutoPark.FactoryMethod.Utils;
using AutoPark.Utils;
using System;

namespace AutoPark.FactorMethod.CreateArea.TruckCreators
{
    class ZilCreator : Creator
    {
        public ZilCreator(string producerCountry) : base(producerCountry)
        {
        }

        public override string ProducerCountry { get; set; }

        public override IMovable Create(int id,
            ColorType colorType,
            RentPeriod rentPeriod,
            long weight,
            decimal cost)
        {
            return new Zil(id, colorType, rentPeriod, weight, cost);
        }
    }
}
