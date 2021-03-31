using Autopark.Entity.Class;
using Autopark.Entity.Enum;

namespace Autopark.FactoryMethod.BaseProduct
{
    public class Truck : Vehicle, IMovable
    {
        private const VehicleType Type = VehicleType.MotorCar;

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
