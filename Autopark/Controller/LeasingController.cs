using Autopark.Model.Entity;
using Autopark.Model.Services;
using Autopark.OutputService;
using System.Collections.Generic;

namespace Autopark.Controller
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
            Transport = transport;
            ConsoleOutput = consoleOutput;
            Engine = new LeasingService(Transport);
        }

        public List<Vehicle> Transport { get; }
        public IOutputService ConsoleOutput { get; }
        private LeasingService Engine { get; set; }


        public void RunController()
        {
            // Engine.RentCostVehicle();
        }
    }
}
