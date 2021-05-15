using Autopark.Entity.Class;
using System.Collections.Generic;

namespace Autopark.View
{
    public interface IVehicleOutputService
    {
        void WriteFile(List<Vehicle> vehicles);
        void WriteFile(Vehicle vehicle);
    }
}
