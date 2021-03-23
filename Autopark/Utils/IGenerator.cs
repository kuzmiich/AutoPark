using AutoPark.FactoryMethod.Utils;
using System.Collections.Generic;

namespace AutoPark.Utils
{
    public interface IGenerator
    {
        List<IMovable> GetMotoCars(int count);
        List<IMovable> GetTruck(int count);
    }
}
