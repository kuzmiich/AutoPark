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
            ConsoleOutput = consoleOutput;
            Engine = new VehicleInfoService(Transport);
        }

        public List<Vehicle> Transport { get; }
        public IOutputService ConsoleOutput { get; }
        private VehicleInfoService Engine { get; set; }

        public void RunController()
        {
            ConsoleOutput.ShowMessage($"Max mileage = {Engine.MaxMileage}");
            ConsoleOutput.ShowMessage($"Min mileage = {Engine.MinMileage}");
            ConsoleOutput.ShowMessage($"Total mileage = {Engine.TotalMileage}");
            ConsoleOutput.ShowMessage($"Total fuel capacity = {Engine.TotalFuelCapacity}");
            ConsoleOutput.ShowMessage($"Total weight = {Engine.TotalWeight}");

            ConsoleOutput.ShowMessage(string.Empty.PadLeft(150, '-'));
        }
    }
}
