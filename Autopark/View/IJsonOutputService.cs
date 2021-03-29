using Autopark.Entity.Class;
using System.Collections.Generic;

namespace Autopark.View
{
    interface IJsonOutputService
    {
        void WriteFile(List<Vehicle> vehicles);
        void WriteFile(Vehicle vehicle);
    }
}
