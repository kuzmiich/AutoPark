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
            Transport = transport;
            ConsoleOutput = consoleOutput;
            Engine = new ParkingService(Transport);
        }

        public List<Vehicle> Transport { get; }
        public IOutputService ConsoleOutput { get; }
        private ParkingService Engine { get; set; }


        public void RunController()
        {
            ConsoleOutput.ShowMessage($"Сost of parking space - {Engine.ParkVehicle(new RentPeriod(5))}");

            ConsoleOutput.ShowMessage($"Сost of parking space - {Engine.ParkVehicle(new RentPeriod(20))}");

            ConsoleOutput.ShowMessage(string.Empty.PadLeft(150, '-'));
        }
    }
}
