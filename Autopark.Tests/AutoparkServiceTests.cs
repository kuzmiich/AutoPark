using Autopark.Entity.Class;
using Autopark.Entity.Enum;
using Autopark.Model.Service.AutoperkService;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Autopark.Tests
{
    [TestClass]
	class AutoparkServiceTests
	{
		[TestMethod]
		public void TotalVehicleCostTest()
		{
			// arrange
			var service = new AutoparkInfoService();
			List<Vehicle> _transport = null;
			// act
			service.BuyVehicle(_transport, 2, VehicleType.Car);
			List<Vehicle> res = null;

			// assert
			Assert.AreEqual(null, res);
		}
	}
}
