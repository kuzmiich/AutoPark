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
    public class AutoparkInfoServiceSellVehicle
    {
        [TestMethod]
        public void SellVehicleTest()
        {
            // arrange
            var transport = new List<Vehicle>()
            {
                new ()
                {
                    Id = 1,
                    Cost = 50000
                }
            };

            // act
            var actualResult = new AutoparkInfoService().SellVehicle(transport);

            // assert
            Assert.AreEqual(50000, actualResult);
        }

        [TestMethod]
        public void SellVehicleNullTransportTest()
        {
            // arrange
            List<Vehicle> transport = null;

            // act
            var ex = Assert.ThrowsException<ArgumentNullException>(() => new AutoparkInfoService().SellVehicle(transport));

            // assert
            Assert.AreEqual(ex.ParamName, "Transport can`t be null");
        }

    }
}
