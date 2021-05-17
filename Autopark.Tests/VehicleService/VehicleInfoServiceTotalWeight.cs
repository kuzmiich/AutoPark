using Autopark.Entity.Class;
using Autopark.Model.Service.AutoparkService;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autopark.Tests
{
	[TestClass]
	public class VehicleInfoServiceTotalWeight
	{
		[TestMethod]
		public void TotalWeightDefaultArrangeTest()
		{
			// arrange
			var vehicles = new List<Vehicle>()
			{
				new ()
				{
					Weight = 500
				},
				new ()
				{
					Weight = 300
				},
				new ()
				{
					Weight = 200
				}
			};

			// act
			var actualResult = new VehicleInfoService().TotalWeight(vehicles);

			// assert
			Assert.AreEqual(1000, actualResult);
		}

		[TestMethod]
		public void TotalWeightNullVehiclesTest()
		{
			// arrange
			List<Vehicle> vehicles = null;

			// act
			var ex = Assert.ThrowsException<ArgumentNullException>(() => new VehicleInfoService().TotalWeight(vehicles));

			// assert
			Assert.AreEqual("Error, vehicles is null", ex.ParamName);
		}
	}
}
