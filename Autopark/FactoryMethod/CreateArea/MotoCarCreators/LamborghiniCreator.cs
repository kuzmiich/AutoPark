using AutoPark.FactorMethod.AbstractProduct;
using AutoPark.FactorMethod.BaseCreator;
using AutoPark.FactoryMethod.Products.MotoCars;
using AutoPark.Utils.Enums;

namespace AutoPark.FactoryMethod.CreateArea.MotoCarCreators
{
    class LamborghiniCreator : Creator
    {
        public LamborghiniCreator(string producerCountry) : base(producerCountry)
        {
        }

        public override string ProducerCountry { get; set; }

        public override Car Create(int id,
            ColorType colorType,
            long weight,
            decimal cost,
            int mileage,
            int totalFuelCapacity
            )
        {
            return new Lamborghini(id, colorType, cost, weight, mileage, totalFuelCapacity);
        }
    }
}
