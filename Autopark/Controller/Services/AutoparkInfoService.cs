using AutoPark.FactoryMethod.Utils;
using AutoPark.OutputService.ConsoleOutput;
using AutoPark.Utils;
using System;
using System.Collections.Generic;

namespace AutoPark.Controller.Services
{
    /// <summary>
    /// Service 2
    /// </summary>
    class AutoparkInfoService : IService
    {
        private readonly List<IMovable> _transport;
        private readonly IConsoleOutput _consoleOutput;

        public AutoparkInfoService(List<IMovable> transport, IConsoleOutput consoleOutput)
        {
            _transport = transport;
            _consoleOutput = consoleOutput;
        }

        public void RunService()
        {
            Console.WriteLine();
        }
    }
}
