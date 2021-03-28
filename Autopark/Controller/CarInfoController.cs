using Autopark.Model.Entity;
using Autopark.Model.Services;
using Autopark.OutputService;
using System.Collections.Generic;

namespace Autopark.Controller
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
            Engine = new VehicleInfoService(Transport);
        }

        public List<Vehicle> Transport { get; }
        public IOutputService OutputService { get; }
        private VehicleInfoService Engine { get; set; }

        public void RunController()
        {
            try
            {
                OutputService.ShowMessage($"Max mileage = {Engine.MaxMileage}");
                OutputService.ShowMessage($"Min mileage = {Engine.MinMileage}");
                OutputService.ShowMessage($"Total mileage = {Engine.TotalMileage}");
                OutputService.ShowMessage($"Total weight = {Engine.TotalWeight}");

                OutputService.ShowMessage(string.Empty.PadLeft(150, '-'));
            }
            catch
            {
                throw;
            }
        }
    }
}
