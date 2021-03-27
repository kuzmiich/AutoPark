using AutoPark.Utils.Engines;
using AutoPark.Utils.Entity;
using AutoPark.Utils.Utils.Interfaces;
using System;
using System.Collections.Generic;

namespace AutoPark.Controllers
{
    /// <summary>
    /// Service 3
    /// </summary>
    class LeasingController : IContoller
    {
        public LeasingController(List<Vehicle> transport, IOutputService consoleOutput)
        {
            Transport = transport;
            ConsoleOutput = consoleOutput;
            Engine = new AutoParkEngine(Transport);
        }

        public List<Vehicle> Transport { get; }
        public IOutputService ConsoleOutput { get; }
        private AutoParkEngine Engine { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public void RunController()
        {
            Console.WriteLine();
        }
    }
}
