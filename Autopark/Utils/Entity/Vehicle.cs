using Autopark.Utils.Enums;

namespace Autopark.Utils.Entity
{
    public class Vehicle
    {
        public Vehicle()
        {
        }

        public Vehicle(int id, RentPeriod rentPeriod)
        {
            Id = id;
            RentPeriod = rentPeriod;
        }

        public Vehicle(int id, ColorType color, decimal cost, long weight, int mileage, int totalFuelCapacity)
        {
            Id = id;
            Color = color;
            Cost = cost;
            Weight = weight;
            Mileage = mileage;
            TotalFuelCapacity = totalFuelCapacity;
        }

        public Vehicle(int id,
                       ColorType color,
                       RentPeriod rentPeriod,
                       decimal cost,
                       long weight,
                       int mileage,
                       int totalFuelCapacity)
        {
            Id = id;
            Color = color;
            RentPeriod = rentPeriod;
            Cost = cost;
            Weight = weight;
            Mileage = mileage;
            TotalFuelCapacity = totalFuelCapacity;
        }

        #region Class Property

        public virtual int Id { get; set; }
        public virtual ColorType Color { get; set; }
        public virtual RentPeriod RentPeriod { get; set; }
        public virtual decimal CostRent { get; set; }
        public decimal Cost { get; set; }
        public long Weight { get; init; }
        public int Mileage { get; init; }
        public int TotalFuelCapacity { get; init; }

        #endregion
    }
}
