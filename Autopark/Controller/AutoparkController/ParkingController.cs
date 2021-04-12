using Autopark.Entity.Class;
using Autopark.Model.Service;
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

        private List<Vehicle> _transport;
        private IOutputService _consoleOutput;
        private static readonly IParkingService _parkingService = new ParkingService();


        public void RunController()
        {
            _consoleOutput.ShowMessage("Parking a vehicle:");

            short vehicleId1 = 5;
            _consoleOutput.ShowMessage($"Сost of parking space, rent period {_transport[vehicleId1].RentPeriod.HourNumber} hours -" +
                $"{_parkingService.ParkVehicle(_transport[vehicleId1].RentPeriod)}");

            short vehicleId2 = 2;
            _consoleOutput.ShowMessage($"Сost of parking space, rent period {_transport[vehicleId2].RentPeriod.HourNumber} hours -" +
                $"{_parkingService.ParkVehicle(_transport[vehicleId2].RentPeriod)}");

            _consoleOutput.ShowMessage(string.Empty.PadLeft(150, '-'));
        }
    }
}
