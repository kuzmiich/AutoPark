using Autopark.Entity.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autopark.Model.Service
{
    interface IVehicleInfoService
    {
        long TotalWeight(IEnumerable<Vehicle> vehicles);

        int MaxMileage(IEnumerable<Vehicle> vehicles);

        double MinMileage(IEnumerable<Vehicle> vehicles);

        double TotalMileage(IEnumerable<Vehicle> vehicles);

        int TotalFuelCapacity(IEnumerable<Vehicle> vehicles);
    }
}
