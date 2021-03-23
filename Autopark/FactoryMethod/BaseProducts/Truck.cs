using AutoPark.FactoryMethod.Utils;
using AutoPark.Utils;
using System;

namespace AutoPark.FactoryMethod.BaseProduct
{
    abstract class Truck : IMovable
    {
        public int Id { get; set; }
        public ColorType Color { get; set; }
        public RentPeriod RentPeriod { get; set; }
        public long Weight { get; init; }
        public decimal Cost { get; set; }
        public const TransportType Type = TransportType.Truck;

        public Truck()
        {
        }

        public Truck(int id, ColorType color, RentPeriod rentPeriod, long weight, decimal cost)
        {
            Id = id;
            Color = color;
            RentPeriod = rentPeriod;
            Weight = weight;
            Cost = cost;
        }

        public override string ToString()
        {
            return $"Id - {Id}, Color - {Color}, Rent period count hour - {RentPeriod.HourCount}," +
            $"Rent period count day - {RentPeriod.DayCount}, Weight - {Weight}, Cost - {Cost}, Type - {Type}";
        }

        public abstract void Move();
    }
}
