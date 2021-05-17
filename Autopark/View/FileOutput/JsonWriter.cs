using Autopark.Entity.Class;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace Autopark.View.FileOutput
{
    public class JsonWriter : IVehicleOutputService<Vehicle>
    {
        private static string _path;

        public JsonWriter(string path)
        {
            _path = path;
        }

        public async void WriteFile(Vehicle vehicle)
        {
            using (FileStream fout = new(_path, FileMode.Create))
            {
                await JsonSerializer.SerializeAsync<Vehicle>(fout, vehicle);
            }
        }
        public async void WriteFile(List<Vehicle> vehicles)
        {
            using (FileStream fout = new(_path, FileMode.Create))
            {
                await JsonSerializer.SerializeAsync<List<Vehicle>>(fout, vehicles);
            }
        }
    }
}
