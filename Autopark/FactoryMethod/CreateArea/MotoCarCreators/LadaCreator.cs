using Autopark.FactorMethod.AbstractProduct;
using Autopark.FactorMethod.BaseCreator;
using Autopark.FactorMethod.Entity.MotoCar;
using Autopark.Utils.Entity;
using Autopark.Utils.Enums;

namespace Autopark.FactorMethod.CreateArea.MotoCarCreators
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
