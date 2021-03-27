using Autopark.Utils.Entity;
using Autopark.Utils.Enums;
using Autopark.Utils.Utils.Interfaces;

namespace Autopark.FactorMethod.AbstractProduct
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class Car : Vehicle, IMovable
    {
        public const VehicleType Type = VehicleType.MotorCar;

        /// <summary>
        /// 
        /// </summary>
        protected Car()
        {
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="rentPeriod"></param>
        /// <param name="costRent"></param>
        protected Car(int id, RentPeriod rentPeriod) 
            : base(id, rentPeriod)
        {
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="color"></param>
        /// <param name="rentPeriod"></param>
        /// <param name="cost"></param>
        /// <param name="weight"></param>
        /// <param name="mileage"></param>
        /// <param name="totalFuelCapacity"></param>
        protected Car(int id, ColorType color, RentPeriod rentPeriod, decimal cost, long weight, int mileage, int totalFuelCapacity) : base(id, color, rentPeriod, cost, weight, mileage, totalFuelCapacity)
        {
        }

        #region Class Property

        /// <summary>
        /// 
        /// </summary>
        public abstract string Brand { get; }

        #endregion

        public override string ToString()
        {
            return $"Id - {Id}, Color - {Color} Weight - {Weight}, Cost - {Cost}, Mileage - {Mileage}," +
                $"Total fuel capacity - {TotalFuelCapacity}, Type - {Type}";
        }


        public abstract void Move();
    }
}
