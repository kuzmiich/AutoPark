using Autopark.Models.Engines;
using Autopark.Utils.Entity;
using Autopark.Utils.Utils.Interfaces;
using System.Collections.Generic;

namespace Autopark.Controllers
{
    /// <summary>
    /// Service 1 - Common information about Vehicles
    /// </summary>
    class CarInfoController : IContoller
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="transport"></param>
        /// <param name="consoleOutput"></param>
        public CarInfoController(List<Vehicle> transport, IOutputService consoleOutput)
        {
            Transport = transport;
            OutputService = consoleOutput;
            Engine = new VehicleInfoEngine(Transport);
        }

        public List<Vehicle> Transport { get; }
        public IOutputService OutputService { get; }
        private VehicleInfoEngine Engine { get; set; }

        public void RunController()
        {
            try
            {
                OutputService.ShowMessage($"Max mileage = {Engine.GetMaxMileage()}");
                OutputService.ShowMessage($"Min mileage = {Engine.GetMinMileage()}");
                OutputService.ShowMessage($"Total mileage = {Engine.GetTotalMileage()}");
                OutputService.ShowMessage($"Total weight = {Engine.GetTotalWeight()}");
                OutputService.ShowMessage(string.Empty.PadLeft(150, '-'));
            }
            catch
            {
                throw;
            }
        }
    }
}
