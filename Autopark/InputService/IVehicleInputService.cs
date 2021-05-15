using Autopark.Entity.Class;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Autopark.InputService
{
    public interface IVehicleInputService<T> where T : Vehicle
    {
        Task<List<T>> GetVehicles();
        Task<T> GetVehicle();
    }
}
