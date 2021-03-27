using Autopark.Models.Engines;
using Autopark.Utils.Engines;
using Autopark.Utils.Entity;
using Autopark.Utils.Utils.Interfaces;
using System;
using System.Collections.Generic;

namespace Autopark.Controllers
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
            Engine = new LeasingEngine(Transport);
        }

        public List<Vehicle> Transport { get; }
        public IOutputService ConsoleOutput { get; }
        private LeasingEngine Engine { get; set; }


        public void RunController()
        {
            Console.WriteLine($"{3}");
        }
    }
}
