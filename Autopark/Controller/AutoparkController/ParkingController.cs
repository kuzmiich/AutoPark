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

            _consoleOutput.ShowMessage($"Сost of parking space, rent period { new RentPeriod(10, 3).HourNumber } hours -" +
                $"{_parkingService.ParkVehicle( new RentPeriod(10, 3)) }");

            _consoleOutput.ShowMessage($"Сost of parking space, rent period {  new RentPeriod(10, 3).HourNumber  } hours -" +
                $"{_parkingService.ParkVehicle( new RentPeriod(1, 0, 1) )}");

            _consoleOutput.ShowMessage(string.Empty.PadLeft(150, '-'));
        }
    }
}
