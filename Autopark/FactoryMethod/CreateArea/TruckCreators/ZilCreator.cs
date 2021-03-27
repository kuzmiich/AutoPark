using Autopark.FactorMethod.BaseCreator;
using Autopark.FactorMethod.Entity.Trucks;
using Autopark.FactoryMethod.BaseProduct;
using Autopark.Utils.Entity;
using Autopark.Utils.Enums;

namespace Autopark.FactorMethod.CreateArea.TruckCreators
{
    class ZilCreator : Creator
    {
        public ZilCreator(string producerCountry) : base(producerCountry)
        {
        }

        public override string ProducerCountry { get; set; }

        public override Truck Create(int id,
            ColorType colorType,
            RentPeriod rentPeriod,
            long weight,
            decimal cost,
            int mileage,
            int totalFuelCapacity
            )
        {
            return new Zil(id, colorType, rentPeriod, cost, weight, mileage, totalFuelCapacity);
        }
    }
}
