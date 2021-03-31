﻿using Autopark.Entity.Class;
using Autopark.Model.Service.AutoparkService;
using Autopark.View;
using System;
using System.Collections.Generic;

namespace Autopark.Controller.AutoparkController
{
    class ParkingController : IContoller
    {
        public ParkingController(List<Vehicle> transport, IOutputService consoleOutput)
        {
            _transport = transport;
            _consoleOutput = consoleOutput;
        }

        private static List<Vehicle> _transport;
        private static IOutputService _consoleOutput;
        private static ParkingService _parkingService = new();


        public void RunController()
        {
            _consoleOutput.ShowMessage("Parking a vehicle:");

            short vehicleId1 = 5;
            _consoleOutput.ShowMessage($"Сost of parking space, rent period {_transport[vehicleId1].RentPeriod.GetHourNumber()} hours -" +
                $"{_parkingService.ParkVehicle(_transport[vehicleId1].RentPeriod)}");

            short vehicleId2 = 2;
            _consoleOutput.ShowMessage($"Сost of parking space, rent period {_transport[vehicleId2].RentPeriod.GetHourNumber()} hours -" +
                $"{_parkingService.ParkVehicle(_transport[vehicleId2].RentPeriod)}");

            _consoleOutput.ShowMessage(string.Empty.PadLeft(150, '-'));
        }
    }
}
