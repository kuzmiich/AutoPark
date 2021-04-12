using Autopark.Entity.Class;
using Autopark.Entity.Enum;
using Autopark.FactoryMethod.AbstractCreator;
using Autopark.FactoryMethod.AbstractProduct;

namespace Autopark.FactoryMethod.CreateArea
{
    public class CarCreator : Creator
    {
        public CarCreator(string producerCountry) : base(producerCountry)
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
            return new Car(id, colorType, rentPeriod, cost, weight, mileage, totalFuelCapacity, brand);
        }
    }
}
