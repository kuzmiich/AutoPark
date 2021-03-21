using System;

namespace Autopark.FactoryMethod.Utils
{
    interface IMovable
    {
        void Move(int id, ColorType colorType, DateTime rentDate,
            long weight, decimal cost);
    }
}
