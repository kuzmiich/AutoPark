using Autopark.Entity.Class;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Autopark.InputService
{
    public interface IJsonInputService
    {
        Task<List<Vehicle>> GetVehicles();
        Task<Vehicle> GetVehicle();
    }
}
