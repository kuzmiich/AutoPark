using Autopark.Entity.Class;
using System.Collections.Generic;

namespace Autopark.View
{
    public interface IVehicleOutputService<T> where T : Vehicle
    {
        void WriteFile(List<T> vehicles);
        void WriteFile(T vehicle);
    }
}
