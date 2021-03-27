using Autopark.Utils.Entity;
using System.Collections.Generic;

namespace Autopark.Utils.Utils.Interfaces
{
    public interface IGeneratorService
    {
        List<Vehicle> GetMotoCars(int count);
        List<Vehicle> GetTrucks(int count);
    }
}
