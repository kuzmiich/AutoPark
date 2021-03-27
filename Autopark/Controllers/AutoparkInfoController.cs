using AutoPark.Utils.Engines;
using AutoPark.Utils.Entity;
using AutoPark.Utils.Utils.Interfaces;
using System;
using System.Collections.Generic;

namespace AutoPark.Controllers
{
    /// <summary>
    /// Service 2
    /// </summary>
    class AutoparkInfoController : IContoller
    {
        public AutoparkInfoController(List<Vehicle> transport, IOutputService consoleOutput)
        {
            Transport = transport;
            ConsoleOutput = consoleOutput;
            Engine = new AutoParkEngine(Transport);
        }

        public List<Vehicle> Transport { get; }
        public IOutputService ConsoleOutput { get; }
        private AutoParkEngine Engine { get; set; }

        public void RunController()
        {
            Console.WriteLine();
        }
    }
}
