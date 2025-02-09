﻿using Autopark.Entity.Class;
using Autopark.Model.Service.AutoparkService;
using Autopark.View;
using System.Collections.Generic;

namespace Autopark.Controller.AutoparkController
{
    /// <summary>
    /// Service 3 - Responsible for the rental of cars
    /// </summary>
    class LeasingController : IContoller
    {


        private List<Vehicle> _transport;
        private IOutputService _consoleOutput;
        private static readonly LeasingService _leasingService = new();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="transport"></param>
        /// <param name="consoleOutput"></param>
        public LeasingController(List<Vehicle> transport, IOutputService consoleOutput)
        {
            _transport = transport;
            _consoleOutput = consoleOutput;
        }


        public void RunController()
        {
            _consoleOutput.ShowMessage("Rent a vehicle:");
            int vehicleId1 = 4;
            _consoleOutput.ShowMessage($"Cost rent a {_transport[vehicleId1].Brand} -" +
                $" {_leasingService.RentVehicle(_transport, new RentPeriod(0, 2), vehicleId1)}");

            int vehicleId2 = 9;
            _consoleOutput.ShowMessage($"Cost rent a {_transport[vehicleId2].Brand} -" +
                $" {_leasingService.RentVehicle(_transport, new RentPeriod(12, 1), vehicleId2)}");

            _consoleOutput.ShowMessage(string.Empty.PadLeft(150, '-'));
        }
    }
}
