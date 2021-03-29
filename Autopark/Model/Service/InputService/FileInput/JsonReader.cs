using Autopark.Entity.Class;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

namespace Autopark.Model.Service.InputService.FileInput
{
    public class JsonFileReader : IJsonInputService
    {
        public readonly string _path;

        public JsonFileReader(string path)
        {
            _path = path;
        }

        public async Task<List<Vehicle>> GetVehicles()
        {
            List<Vehicle> vehicles;
            using (FileStream fin = new(_path, FileMode.OpenOrCreate))
            {
                try
                {
                    vehicles = await JsonSerializer.DeserializeAsync<List<Vehicle>>(fin);
                }
                catch
                {
                    vehicles = new List<Vehicle>();
                }
            }
            return vehicles;
        }
        public async Task<Vehicle> GetVehicle()
        {
            Vehicle vehicle;
            using (FileStream fin = new(_path, FileMode.OpenOrCreate))
            {
                try
                {
                    vehicle = await JsonSerializer.DeserializeAsync<Vehicle>(fin);
                }
                catch
                {
                    vehicle = new Vehicle();
                }
            }
            return vehicle;
        }
    }
}
