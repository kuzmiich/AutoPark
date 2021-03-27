using AutoPark.Utils.Enums;

namespace AutoPark.Utils.Entity
{
    public class Vehicle
    {
        public Vehicle()
        {
        }

        public Vehicle(int id, RentPeriod rentPeriod, decimal costRent)
        {
            Id = id;
            RentPeriod = rentPeriod;
            CostRent = costRent;
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
                       decimal costRent,
                       decimal cost,
                       long weight,
                       int mileage,
                       int totalFuelCapacity)
        {
            Id = id;
            Color = color;
            RentPeriod = rentPeriod;
            CostRent = costRent;
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
