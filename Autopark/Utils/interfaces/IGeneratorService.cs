using AutoPark.Utils.Entity;
using System.Collections.Generic;

namespace AutoPark.Utils.Utils.Interfaces
{
    public interface IGeneratorService
    {
        List<Vehicle> GetMotoCars(int count);
        List<Vehicle> GetTruck(int count);
    }
}
