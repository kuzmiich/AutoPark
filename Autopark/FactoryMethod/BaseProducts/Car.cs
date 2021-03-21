using Autopark.FactoryMethod.Utils;
using System;

namespace Autopark.FactorMethod.BaseProduct
{
    abstract class Car : IMovable
    {
        public virtual int Id { get; set; }
        public virtual ColorType Color { get; set; }
        public DateTime RentDate { get; set; }
        public virtual long Weight { get; set; }
        public virtual decimal CostRent { get; set; }
        public const TransportType Type = TransportType.MotorCar;

        protected Car(int id, ColorType color, DateTime rentDate, long weight, decimal cost)
        {
            Id = id;
            Color = color;
            RentDate = rentDate;
            Weight = weight;
            CostRent = cost;
        }

        public abstract void Move(int id, ColorType colorType,
            DateTime rentDate, long weight, decimal cost);
    }
}
