using Autopark.Entity.Class;
using Autopark.Model.Service.AutoparkService;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Autopark.Tests
{
    [TestClass]
    public class AutoparkInfoServiceTotalVehicle
    {
        [TestMethod]
        public void TotalVehicleCostDefaultTransportTest()
        {
            // arrange
            var transport = new List<Vehicle>()
            {
                new ()
                {
                    Id = 1,
                    Cost = 50000
                },
                new ()
                {
                    Id = 1,
                    Cost = 23000,
                }
            };

            // act
            var actualResult = AutoparkInfoService.TotalVehicleCost(transport);

            // assert
            Assert.AreEqual(73000, actualResult);
        }

        [TestMethod]
        public void TotalVehicleCostNullTransportTest()
        {
            // arrange
            List<Vehicle> transport = null;

            // act
            var ex = Assert.ThrowsException<ArgumentNullException>(() => AutoparkInfoService.TotalVehicleCost(transport));

            // assert
            Assert.AreEqual(ex.ParamName, "Transport can`t be null");
        }
    }
}
