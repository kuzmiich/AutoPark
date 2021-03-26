using AutoPark.Models.Utils.Entity;
using System.Collections.Generic;

namespace AutoPark.Models.Utils.Interfaces
{
    public interface IGenerator
    {
        List<Vehicle> GetMotoCars(int count);
        List<Vehicle> GetTruck(int count);
    }
}
