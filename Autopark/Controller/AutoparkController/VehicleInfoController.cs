using Autopark.Entity.Class;
using Autopark.Model.Service.AutoperkService;
using Autopark.View;
using System.Collections.Generic;

namespace Autopark.Controller.AutoparkController
{
    /// <summary>
    /// Service 1 - Common information about Vehicles
    /// </summary>
    class VehicleInfoController : IContoller
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="transport"></param>
        /// <param name="consoleOutput"></param>
        public VehicleInfoController(List<Vehicle> transport, IOutputService consoleOutput)
        {
            _transport = transport;
            _consoleOutput = consoleOutput;
            _vehicleInfoService = new VehicleInfoService(_transport);
        }

        private static List<Vehicle> _transport;
        private static IOutputService _consoleOutput;
        private static VehicleInfoService _vehicleInfoService;

        public void RunController()
        {
            _consoleOutput.ShowMessage($"Max mileage = {_vehicleInfoService.MaxMileage}");
            _consoleOutput.ShowMessage($"Min mileage = {_vehicleInfoService.MinMileage}");
            _consoleOutput.ShowMessage($"Total mileage = {_vehicleInfoService.TotalMileage}");
            _consoleOutput.ShowMessage($"Total fuel capacity = {_vehicleInfoService.TotalFuelCapacity}");
            _consoleOutput.ShowMessage($"Total weight = {_vehicleInfoService.TotalWeight}");

            _consoleOutput.ShowMessage(string.Empty.PadLeft(150, '-'));
        }
    }
}
