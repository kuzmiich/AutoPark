using Autopark.Entity.Class;
using System.Collections.Generic;

namespace Autopark.Model.Service
{
    interface ILeasingService
    {
        decimal RentVehicle(List<Vehicle> transport, RentPeriod period, int vehicleId);
    }
}
