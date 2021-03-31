using Autopark.Entity.Class;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Autopark.InputService
{
    interface IJsonInputService
    {
        Task<List<Vehicle>> GetVehicles();
        Task<Vehicle> GetVehicle();
    }
}
