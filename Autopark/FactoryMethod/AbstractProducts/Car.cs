using AutoPark.FactoryMethod.Utils;
using AutoPark.Models.Utils.Entity;
using AutoPark.Models.Utils.Interfaces;

namespace AutoPark.FactorMethod.AbstractProduct
{
    public abstract class Car : Vehicle, IMovable
    {
        public const TransportType Type = TransportType.MotorCar;

        protected Car()
        {
        }

        protected Car(int id, RentPeriod rentPeriod, decimal costRent) 
            : base(id, rentPeriod, costRent)
        {
        }

        protected Car(int id, ColorType color, decimal cost, long weight, int mileage, int totalFuelCapacity) 
            : base(id, color, cost, weight, mileage, totalFuelCapacity)
        {
        }


        #region Class Property

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
