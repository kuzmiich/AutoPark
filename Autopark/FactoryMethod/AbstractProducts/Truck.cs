using Autopark.Utils.Entity;
using Autopark.Utils.Enums;
using Autopark.Utils.Utils.Interfaces;

namespace Autopark.FactoryMethod.BaseProduct
{
    public abstract class Truck : Vehicle, IMovable
    {
        public const VehicleType Type = VehicleType.Truck;

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
