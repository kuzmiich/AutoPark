using Autopark.Entity.Class;
using Autopark.Entity.Const;
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
    public class ParkingServiceParkVehicle
    {
        [TestMethod]
        public void ParkVehicleDefaultArrangeTest()
        {
            // arrange
            var period = new RentPeriod(10, 1);

            // act
            var actualResult = new ParkingService().ParkVehicle(period);

            // assert
            Assert.AreEqual(170, actualResult);
        }

        [TestMethod]
        public void ParkVehicleNullPeriodTest()
        {
            // arrange
            RentPeriod period = null;

            // act
            var ex = Assert.ThrowsException<ArgumentNullException>(() => new ParkingService().ParkVehicle(period));

            // assert
            Assert.AreEqual("period cannot be null", ex.ParamName);
        }
    }
}
