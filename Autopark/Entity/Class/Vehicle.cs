using Autopark.Entity.Enum;

namespace Autopark.Entity.Class
{
    public class Vehicle
    {
        public Vehicle()
        {
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
        public virtual string Brand { get; }
        public decimal Cost { get; set; }
        public long Weight { get; set; }
        public int Mileage { get; init; }
        public int TotalFuelCapacity { get; init; }

        #endregion

        public override string ToString()
        {
            return $"Id - {Id}, Color - {Color}, Rent period hour number - {RentPeriod.HourNumber}, Rent period day number - {RentPeriod.DayNumber}, " +
                $"Cost - {Cost}, Weight - {Weight}, Mileage - {Mileage}, Total fuel capacity - {TotalFuelCapacity}";
        }
    }
}
