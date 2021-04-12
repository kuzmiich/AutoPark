using Autopark.Entity.Class;
using Autopark.Model.Service;
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
            _outputService = consoleOutput;
        }

        private List<Vehicle> _transport;
        private IOutputService _outputService;
        private static readonly IVehicleInfoService _vehicleInfoService = new VehicleInfoService();

        public void RunController()
        {
            _outputService.ShowMessage($"Max mileage = {_vehicleInfoService.MaxMileage(_transport)}");
            _outputService.ShowMessage($"Min mileage = {_vehicleInfoService.MinMileage(_transport)}");
            _outputService.ShowMessage($"Total mileage = {_vehicleInfoService.TotalMileage(_transport)}");
            _outputService.ShowMessage($"Total fuel capacity = {_vehicleInfoService.TotalFuelCapacity(_transport)}");
            _outputService.ShowMessage($"Total weight = {_vehicleInfoService.TotalWeight(_transport)}");

            _outputService.ShowMessage(string.Empty.PadLeft(150, '-'));
        }
    }
}
