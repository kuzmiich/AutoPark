using Autopark.Entity.Class;
using Autopark.Model.Service.AutoperkService;
using Autopark.View;
using System.Collections.Generic;

namespace Autopark.Controller.AutoparkController
{
    /// <summary>
    /// Service 3 - Responsible for the rental of cars
    /// </summary>
    class LeasingController : IContoller
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="transport"></param>
        /// <param name="consoleOutput"></param>
        public LeasingController(List<Vehicle> transport, IOutputService consoleOutput)
        {
            _transport = transport;
            _consoleOutput = consoleOutput;
            _leasingService = new LeasingService(_transport);
        }

        private static List<Vehicle> _transport;
        private static IOutputService _consoleOutput;
        private static LeasingService _leasingService;


        public void RunController()
        {
            _consoleOutput.ShowMessage("Rent a vehicle:");
            _consoleOutput.ShowMessage($"Cost rent a {_transport[4].Brand} -" +
                $" {_leasingService.RentVehicle(new RentPeriod(0, 2), 4)}");

            _consoleOutput.ShowMessage($"Cost rent a {_transport[9].Brand} -" +
                $" {_leasingService.RentVehicle(new RentPeriod(12, 1), 9)}");

            _consoleOutput.ShowMessage(string.Empty.PadLeft(150, '-'));
        }
    }
}
