using Autopark.Entity.Enum;
using Autopark.Entity.Interface;
using System.ComponentModel.DataAnnotations;

namespace Autopark.Entity.Class
{
    public class Vehicle : IMovable
    {
        public Vehicle()
        {
        }

        public Vehicle(int id,
                       ColorType color,
                       decimal cost,
                       long weight,
                       int mileage,
                       int totalFuelCapacity,
                       string brand)
        {
            Id = id;
            Color = color;
            Cost = cost;
            Weight = weight;
            Mileage = mileage;
            TotalFuelCapacity = totalFuelCapacity;
            Brand = brand;
        }

        #region Class Property
        [Range(1, int.MaxValue)]
        public virtual int Id { get; set; }

        public virtual ColorType Color { get; set; }

        [Range(1, double.MaxValue)]
        public decimal Cost { get; set; }

        [Range(1, long.MaxValue)]
        public long Weight { get; set; }

        [Range(1, int.MaxValue)]
        public int Mileage { get; init; }

        [Range(1, int.MaxValue)]
        public int TotalFuelCapacity { get; init; }
        
        [MaxLength(100)]
        public virtual string Brand { get; init; }

        #endregion

        public virtual string Move()
        {
            return "Vehicle move...";
        }

        public override string ToString()
        {
            return $"Id - {Id}, Color - {Color} Cost - {Cost}, Weight - {Weight}, Mileage - {Mileage}," +
                $"Total fuel capacity - {TotalFuelCapacity}";
        }
    }
}
