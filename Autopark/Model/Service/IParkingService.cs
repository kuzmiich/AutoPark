using Autopark.Entity.Class;

namespace Autopark.Model.Service
{
    interface IParkingService
    {
        decimal ParkVehicle(RentPeriod period);
    }
}
