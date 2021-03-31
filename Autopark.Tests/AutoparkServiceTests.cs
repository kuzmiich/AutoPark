using Autopark.Entity.Class;
using Autopark.Model.Service.AutoperkService;
using Autopark.Model.Service.GenerationService;
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
			var res = service.TotalVehicleCost(_transport);

			// assert
			Assert.AreEqual(1000, res);
		}
	}
}
