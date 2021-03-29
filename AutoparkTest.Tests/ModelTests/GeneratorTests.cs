using Autopark.Model.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AutoparkTest.ModelTests
{
    [TestClass]
	class GeneratorTests
	{
		[TestMethod]
		public void GenerateTruck()
		{
			// arrange
			var generator = new Generator();

			// act
			var res = generator.GetTruck(1);

			// assert
			Assert.IsNotNull(res);
		}
		[TestMethod]
		public void GenerateMotoCar()
		{
			// arrange
			var generator = new Generator();

			// act
			var res = generator.GetMotoCar(1);

			// assert
			Assert.AreEqual(7, res);
		}
	}
}
