using Autopark.Entity.Class;
using System.Collections.Generic;

namespace Autopark.Model.Service
{
    public interface IGenerationService
    {
        List<Vehicle> GetMotoCars(int count);
        List<Vehicle> GetTrucks(int count);
    }
}
