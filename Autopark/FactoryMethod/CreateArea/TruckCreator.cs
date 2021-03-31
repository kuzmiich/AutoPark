using Autopark.Entity.Class;
using Autopark.Entity.Enum;
using Autopark.FactoryMethod.AbstractCreator;
using Autopark.FactoryMethod.AbstractProduct;

namespace Autopark.FactoryMethod.CreateArea
{
    class TruckCreator : Creator
    {
        public TruckCreator(string producerCountry) : base(producerCountry)
        {
        }

        public override string ProducerCountry { get; set; }

        public override Vehicle CreateVehicle(int id,
            ColorType colorType,
            RentPeriod rentPeriod,
            long weight,
            decimal cost,
            int mileage,
            int totalFuelCapacity,
            string brand
            )
        {
            return new Truck(id, colorType, rentPeriod, cost, weight, mileage, totalFuelCapacity, brand);
        }
    }
}
