using Autopark.Model.Entity;
using System.Collections.Generic;

namespace Autopark.Model.Services.Base
{
    public interface IGeneratorService
    {
        List<Vehicle> GetMotoCars(int count);
        List<Vehicle> GetTrucks(int count);
    }
}
