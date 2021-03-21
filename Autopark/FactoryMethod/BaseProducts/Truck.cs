using Autopark.FactoryMethod.Utils;
using System;

namespace Autopark.FactoryMethod.BaseProduct
{
    abstract class Truck : IMovable
    {
        public int Id { get; set; }
        public ColorType Color { get; set; }
        public DateTime RentDate { get; set; }
        public long Weight { get; set; }
        public decimal Cost { get; set; }
        public const TransportType Type = TransportType.Truck;

        public Truck()
        {
        }

        public Truck(int id, ColorType color, DateTime rentDate, long weight, decimal cost)
        {
            Id = id;
            Color = color;
            RentDate = rentDate;
            Weight = weight;
            Cost = cost;
        }

        public abstract void Move(int id, ColorType colorType, DateTime rentDate,
            long weight, decimal cost);
    }
}
