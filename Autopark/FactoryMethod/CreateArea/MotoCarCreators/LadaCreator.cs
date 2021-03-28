using Autopark.FactoryMethod.AbstractProduct;
using Autopark.FactoryMethod.BaseCreator;
using Autopark.FactoryMethod.Entity.MotoCar;
using Autopark.Model.Entity;
using Autopark.Model.Enum;

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
