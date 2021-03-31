using Autopark.Entity.Class;
using Autopark.Entity.Const;
using Autopark.Entity.Enum;

namespace Autopark.FactoryMethod.AbstractProduct
{
    /// <summary>
    /// 
    /// </summary>
    public class Car : Vehicle
    {
        public const VehicleType Type = VehicleType.MotorCar;
        private string _brand;

        public Car()
        {
        }

        public Car(int id, ColorType color, RentPeriod rentPeriod, decimal cost, long weight, int mileage, int totalFuelCapacity) : base(id, color, rentPeriod, cost, weight, mileage, totalFuelCapacity)
        {
        }

        #region Class Property

        #endregion

        public override string ToString()
        {
            return $"{base.ToString()}, {Type}, {Brand}";
        }

        public void Move()
        {

        }
    }
}
