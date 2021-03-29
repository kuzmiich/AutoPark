using Autopark.Entity.Class;
using Autopark.Entity.Enum;
using Autopark.FactoryMethod.AbstractProduct;
using Autopark.FactoryMethod.BaseCreator;
using Autopark.FactoryMethod.Products.MotoCars;

namespace Autopark.FactoryMethod.CreateArea.MotoCarCreators
{
    class LamborghiniCreator : Creator
    {
        public LamborghiniCreator(string producerCountry) : base(producerCountry)
        {
        }

        public override string ProducerCountry { get; set; }

        public override Car Create(int id,
            ColorType colorType,
            RentPeriod rentPeriod,
            long weight,
            decimal cost,
            int mileage,
            int totalFuelCapacity
            )
        {
            return new Lamborghini(id, colorType, rentPeriod, cost, weight, mileage, totalFuelCapacity);
        }
    }
}
