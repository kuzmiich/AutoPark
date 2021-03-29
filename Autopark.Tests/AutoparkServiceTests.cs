using Autopark.Model.Service.AutoperkService;
using Autopark.Model.Service.GenerationService;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Autopark.Tests
{
    [TestClass]
	class AutoparkServiceTests
	{
		[TestMethod]
		public void TotalVehicleCostTest()
		{
			// arrange
			VehicleGeneration generator = new();
			AutoparkInfoService service = new(generator.GetMotoCars(5));

			// act
			var res = service.TotalVehicleCost();

			// assert
			Assert.AreEqual(1000, res);
		}
	}
}
