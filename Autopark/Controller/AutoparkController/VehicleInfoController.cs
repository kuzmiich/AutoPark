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
            Transport = transport;
            OutputService = consoleOutput;
            Engine = new VehicleInfoService(Transport);
        }

        public List<Vehicle> Transport { get; }
        public IOutputService OutputService { get; }
        private VehicleInfoService Engine { get; set; }

        public void RunController()
        {
            OutputService.ShowMessage($"Max mileage = {Engine.MaxMileage}");
            OutputService.ShowMessage($"Min mileage = {Engine.MinMileage}");
            OutputService.ShowMessage($"Total mileage = {Engine.TotalMileage}");
            OutputService.ShowMessage($"Total fuel capacity = {Engine.TotalFuelCapacity}");
            OutputService.ShowMessage($"Total weight = {Engine.TotalWeight}");

            OutputService.ShowMessage(string.Empty.PadLeft(150, '-'));
        }
    }
}
