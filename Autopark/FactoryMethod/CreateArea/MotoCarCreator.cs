using Autopark.Entity.Class;
using Autopark.Entity.Enum;
using Autopark.FactoryMethod.AbstractCreator;
using Autopark.FactoryMethod.AbstractProduct;

namespace Autopark.FactoryMethod.CreateArea.MotoCarCreators
{
    class MotoCarCreator : Creator
    {
        public MotoCarCreator(string producerCountry) : base(producerCountry)
        {
        }

        public override string ProducerCountry { get; set; }

        public override Vehicle Create(int id,
            ColorType colorType,
            RentPeriod rentPeriod,
            long weight,
            decimal cost,
            int mileage,
            int totalFuelCapacity
            )
        {
            return new Car(id, colorType, rentPeriod, cost, weight, mileage, totalFuelCapacity);
        }
    }
}
