using Autopark.Entity.Class;
using Autopark.Entity.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autopark.Model.Service
{
    interface IAutoparkInfoService
    {
        decimal SellVehicle(List<Vehicle> transport);

        decimal SellVehicle(List<Vehicle> transport, int count);

        public void BuyVehicle(List<Vehicle> transport, int count, VehicleType type);

        void BuyVehicle(List<Vehicle> transport, VehicleType type);
    }
}
