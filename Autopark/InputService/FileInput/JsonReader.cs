using Autopark.Entity.Class;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

namespace Autopark.InputService.FileInput
{
    public class JsonFileReader : IVehicleInputService<Vehicle>
    {
        public readonly string _path;

        public JsonFileReader(string path)
        {
            _path = path;
        }

        public async Task<List<Vehicle>> GetVehicles()
        {
            if (File.Exists(_path))
            {
                using (FileStream fin = new(_path, FileMode.OpenOrCreate))
                {
                    return await JsonSerializer.DeserializeAsync<List<Vehicle>>(fin);
                }
            }

            return new List<Vehicle>();
        }
        public async Task<Vehicle> GetVehicle()
        {
            if (File.Exists(_path))
            {
                using (FileStream fin = new(_path, FileMode.OpenOrCreate))
                {
                    return await JsonSerializer.DeserializeAsync<Vehicle>(fin);
                }
            }
            
            return new Vehicle();
        }
    }
}
