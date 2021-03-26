using AutoPark.FactoryMethod.Utils;
using AutoPark.Models.Utils.Entity;
using AutoPark.Models.Utils.Interfaces;

namespace AutoPark.FactoryMethod.BaseProduct
{
    public abstract class Truck : Vehicle, IMovable
    {
        public const TransportType Type = TransportType.Truck;

        public Truck()
        {
        }

        protected Truck(int id, RentPeriod rentPeriod, decimal costRent) 
            : base(id, rentPeriod, costRent)
        {
        }

        protected Truck(int id, ColorType color, decimal cost, long weight, int mileage, int totalFuelCapacity) 
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
