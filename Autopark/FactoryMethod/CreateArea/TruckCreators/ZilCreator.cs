using AutoPark.FactorMethod.BaseCreator;
using AutoPark.FactorMethod.Entity.Trucks;
using AutoPark.FactoryMethod.BaseProduct;
using AutoPark.FactoryMethod.Utils;

namespace AutoPark.FactorMethod.CreateArea.TruckCreators
{
    class ZilCreator : Creator
    {
        public ZilCreator(string producerCountry) : base(producerCountry)
        {
        }

        public override string ProducerCountry { get; set; }

        public override Truck Create(int id,
            ColorType colorType,
            long weight,
            decimal cost,
            int mileage,
            int totalFuelCapacity
            )
        {
            return new Zil(id, colorType, cost, weight, mileage, totalFuelCapacity);
        }
    }
}
