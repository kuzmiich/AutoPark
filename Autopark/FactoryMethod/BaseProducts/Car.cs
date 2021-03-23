using AutoPark.FactoryMethod.Utils;
using AutoPark.Utils;
using System;

namespace AutoPark.FactorMethod.BaseProduct
{
    abstract class Car : IMovable
    {
        public virtual int Id { get; set; }
        public virtual ColorType Color { get; set; }
        public virtual RentPeriod RentPeriod { get; set; }
        public decimal Cost { get; set; }
        public long Weight { get; init; }

        public virtual decimal CostRent { get; set; }
        public double KM { get; private set; }
        public const TransportType Type = TransportType.MotorCar;

        protected Car(int id, ColorType color, RentPeriod rentDate, long weight, decimal cost)
        {
            Id = id;
            Color = color;
            RentPeriod = rentDate;
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
