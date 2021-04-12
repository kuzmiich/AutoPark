using Autopark.Entity.Class;
using System.Collections.Generic;

namespace Autopark.Model.Service.GenerationService
{
    public interface IGenerationService
    {
        List<Vehicle> GetCars(int count);
        List<Vehicle> GetTrucks(int count);
    }
}
