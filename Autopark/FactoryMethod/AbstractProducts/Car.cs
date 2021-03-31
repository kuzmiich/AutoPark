using Autopark.Entity.Class;
using Autopark.Entity.Enum;

namespace Autopark.FactoryMethod.AbstractProduct
{
    /// <summary>
    /// 
    /// </summary>
    public class Car : Vehicle, IMovable
    {
        public const VehicleType Type = VehicleType.MotorCar;

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
