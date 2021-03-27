using AutoPark.FactorMethod.AbstractProduct;
using AutoPark.FactorMethod.BaseCreator;
using AutoPark.FactorMethod.Entity.MotoCar;
using AutoPark.Utils.Enums;

namespace AutoPark.FactorMethod.CreateArea.MotoCarCreators
{
    class LadaCreator : Creator
    {
        public LadaCreator(string producerCountry) : base(producerCountry)
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
            return new Lada(id, colorType, cost, weight, mileage, totalFuelCapacity);
        }
    }
}
