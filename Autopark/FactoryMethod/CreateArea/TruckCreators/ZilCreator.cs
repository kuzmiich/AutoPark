using Autopark.Entity.Class;
using Autopark.Entity.Enum;
using Autopark.FactoryMethod.BaseCreator;
using Autopark.FactoryMethod.BaseProduct;
using Autopark.FactoryMethod.Entity.Trucks;

namespace Autopark.FactoryMethod.CreateArea.TruckCreators
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
