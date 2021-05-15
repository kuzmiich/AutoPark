using System;
using System.Collections.Generic;
using Autopark.Entity.Class;
using Autopark.Entity.Const;
using Autopark.Entity.Enum;
using Autopark.Model.Service.AutoparkService;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Autopark.Tests
{
    [TestClass]
    public class LeasingServiceRentVehicle
    {

        [TestMethod]
        public void RentVehicleDefaultArrangeTest()
        {
            // arrange
            var transport = new List<Vehicle>()
            {
                new ()
                {
                    Id = 1,
                    Brand = VehicleBrand.Lada
                },
            };
            var period = new RentPeriod(10, 1);

            var id = 0;
            // act
            var actualResult = new LeasingService().RentVehicle(transport, period, id);

            // assert
            Assert.AreEqual(850, actualResult);
        }

        #region Incorrect test
        [TestMethod]
        public void RentVehicleIncorrectIdTest()
        {
            // arrange
            var transport = new List<Vehicle>();
            RentPeriod period = new RentPeriod(1);
            var id = -10;
            
            // act
            var ex = Assert.ThrowsException<ArgumentException>(() => new LeasingService().RentVehicle(transport, period, id));

            // assert
            Assert.AreEqual(ex.Message, "Error, invalid id.");
        }

        [TestMethod]
        public void RentVehicleIncorrectBrandTest()
        {
            // arrange
            var transport = new List<Vehicle>()
            {
                new ()
                {
                    Id = 1,
                    Brand = VehicleBrand.Man
                }
            };
            RentPeriod period = new RentPeriod(1);
            var id = 0;

            // act
            var ex = Assert.ThrowsException<ArgumentOutOfRangeException>(() => new LeasingService().RentVehicle(transport, period, id));

            // assert
            Assert.AreEqual(ex.ParamName, "Error, this vehicle brand not found");
        }
        #endregion

        #region Not value
        [TestMethod]
        public void RentVehicleNotBrandTest()
        {
            // arrange
            var transport = new List<Vehicle>()
            {
                new ()
                {
                }
            };
            var period = new RentPeriod(1);
            var id = 0;

            // act
            var ex = Assert.ThrowsException<ArgumentNullException>(() => new LeasingService().RentVehicle(transport, period, id));

            // assert
            Assert.AreEqual(ex.ParamName, "Error, vehicle brand not found");
        }
        #endregion
    }
}
