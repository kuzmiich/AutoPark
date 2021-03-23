using AutoPark.FactorMethod.BaseCreator;
using AutoPark.FactoryMethod.Products.MotoCars;
using AutoPark.FactoryMethod.Utils;
using AutoPark.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoPark.FactoryMethod.CreateArea.MotoCarCreators
{
    class LamborghiniCreator : Creator
    {
        public LamborghiniCreator(string producerCountry) : base(producerCountry)
        {
        }

        public override string ProducerCountry { get; set; }

        public override IMovable Create(int id,
            ColorType colorType,
            RentPeriod rentPeriod,
            long weight,
            decimal cost)
        {
            return new Lamborghini(id, colorType, rentPeriod, weight, cost);
        }
    }
}
