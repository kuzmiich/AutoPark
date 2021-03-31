using Autopark.Entity.Class;
using Autopark.Entity.Enum;

namespace Autopark.FactoryMethod.BaseProduct
{
    public class Truck : Vehicle
    {
        public const VehicleType Type = VehicleType.MotorCar;

        public Truck(int id, ColorType color, RentPeriod rentPeriod, decimal cost, long weight, int mileage, int totalFuelCapacity) : base(id, color, rentPeriod, cost, weight, mileage, totalFuelCapacity)
        {
        }

        public Truck()
        {
        }

        #region Class Property


        #endregion

        public override string ToString()
        {
            return $"{base.ToString()}, {Type}";
        }

        public void Move()
        {

        }
    }
}
