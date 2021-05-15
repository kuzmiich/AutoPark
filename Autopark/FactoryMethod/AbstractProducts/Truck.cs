using Autopark.Entity.Class;
using Autopark.Entity.Enum;

namespace Autopark.FactoryMethod.AbstractProduct
{
    public class Truck : Vehicle
    {
        public const VehicleType Type = VehicleType.Car;

        public Truck()
        {
        }

        public Truck(int id,
            ColorType color,
            decimal cost,
            long weight,
            int mileage,
            int totalFuelCapacity,
            string brand) 
            : base(id, color, cost, weight, mileage, totalFuelCapacity, brand)
        {
        }

        public override string Brand { get; init; }

        public override string ToString()
        {
            return $"{base.ToString()}, Type - {Type}, Brand - {Brand}";
        }

        public override string Move()
        {
            return $"{Brand} move...";
        }
    }
}
