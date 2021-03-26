using AutoPark.Models.Engine;
using AutoPark.Models.Utils.Entity;
using AutoPark.Models.Utils.Interfaces;
using AutoPark.OutputService;
using System;
using System.Collections.Generic;

namespace AutoPark.Controller.Services
{
    /// <summary>
    /// Service 2
    /// </summary>
    class AutoparkInfoService : IService
    {
        public AutoparkInfoService(List<Vehicle> transport, IOutputService consoleOutput)
        {
            Transport = transport;
            ConsoleOutput = consoleOutput;
            Engine = new AutoParkEngine(Transport);
        }

        public List<Vehicle> Transport { get; }
        public IOutputService ConsoleOutput { get; }
        private AutoParkEngine Engine { get; set; }

        public void RunService()
        {
            Console.WriteLine();
        }
    }
}
