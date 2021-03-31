using Autopark.Entity.Class;
using Autopark.Entity.Enum;
using Autopark.Model.Service.AutoperkService;
using System.Collections.Generic;
using Xunit;

namespace Autopark.Test
{
    public class AutoparkServiceTests
    {
        [Fact]
        public void TotalVehicleCostTest()
        {
            // arrange
            var service = new AutoparkInfoService();
            List<Vehicle> _transport = null;
            // act
            service.BuyVehicle(_transport, 2, VehicleType.Car);
            List<Vehicle> res = null;

            // assert
            // Assert.AreEqual(null, res);
        }
    }
}
