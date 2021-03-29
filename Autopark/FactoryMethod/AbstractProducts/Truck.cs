using Autopark.Entity.Class;
using Autopark.Entity.Enum;

namespace Autopark.FactoryMethod.BaseProduct
{
    public abstract class Truck : Vehicle, IMovable
    {
        private const VehicleType Type = VehicleType.MotorCar;

        public Truck()
        {
        }

        protected Truck(int id, RentPeriod rentPeriod) 
            : base(id, rentPeriod)
        {
        }

        protected Truck(int id, ColorType color, decimal cost, long weight, int mileage, int totalFuelCapacity) 
            : base(id, color, cost, weight, mileage, totalFuelCapacity)
        {
        }

        #region Class Property


        #endregion

        public override string ToString()
        {
            return $"{base.ToString()}, {Type}";
        }

        public abstract void Move();
    }
}
