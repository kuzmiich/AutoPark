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
            Transport = transport;
            ConsoleOutput = consoleOutput;
            Engine = new LeasingService(Transport);
        }

        public List<Vehicle> Transport { get; }
        public IOutputService ConsoleOutput { get; }
        private LeasingService Engine { get; set; }


        public void RunController()
        {
            ConsoleOutput.ShowMessage($"Cost rent a {Transport[4].Brand} -" +
                $" {Engine.RentVehicle(new RentPeriod(0, 2), 4)}");

            ConsoleOutput.ShowMessage($"Cost rent a {Transport[9].Brand} -" +
                $" {Engine.RentVehicle(new RentPeriod(12, 1), 9)}");
        }
    }
}
