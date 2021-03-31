using Autopark.Entity.Class;
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
            _parkingService = new ParkingService(_transport);
        }

        private static List<Vehicle> _transport;
        private static IOutputService _consoleOutput;
        private static ParkingService _parkingService;


        public void RunController()
        {
            _consoleOutput.ShowMessage("Parking a vehicle:");

            short hourNumber1 = 5;
            _consoleOutput.ShowMessage($"Сost of parking space, rent period {hourNumber1} hours -" +
                $"{_parkingService.ParkVehicle(new RentPeriod(hourNumber1))}");

            short hourNumber2 = 20;
            _consoleOutput.ShowMessage($"Сost of parking space, rent period {hourNumber2} hours -" +
                $"{_parkingService.ParkVehicle(new RentPeriod(hourNumber2))}");

            _consoleOutput.ShowMessage(string.Empty.PadLeft(150, '-'));
        }
    }
}
