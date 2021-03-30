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
            short hourNumber1 = 5;
            ConsoleOutput.ShowMessage($"Сost of parking space, rent period {hourNumber1} hours -" +
                $" {Engine.ParkVehicle(new RentPeriod(hourNumber1))}");

            short hourNumber2 = 20;
            ConsoleOutput.ShowMessage($"Сost of parking space, rent period {hourNumber2} hours -" +
                $" {Engine.ParkVehicle(new RentPeriod(hourNumber2))}");

            ConsoleOutput.ShowMessage(string.Empty.PadLeft(150, '-'));
        }
    }
}
