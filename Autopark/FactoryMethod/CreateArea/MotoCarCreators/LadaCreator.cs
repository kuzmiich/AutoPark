using Autopark.Entity.Class;
using Autopark.Entity.Enum;
using Autopark.FactoryMethod.AbstractProduct;
using Autopark.FactoryMethod.AbstractCreator;
using Autopark.FactoryMethod.Entity.MotoCar;

namespace Autopark.FactoryMethod.CreateArea.MotoCarCreators
{
    class LadaCreator : Creator
    {
        public LadaCreator(string producerCountry) : base(producerCountry)
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
            return new Lada(id, colorType, rentPeriod, cost, weight, mileage, totalFuelCapacity);
        }
    }
}
