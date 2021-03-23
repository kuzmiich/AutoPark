using AutoPark.FactoryMethod.Utils;
using AutoPark.OutputService.ConsoleOutput;
using AutoPark.Utils;
using System;
using System.Collections.Generic;

namespace AutoPark.Controller.Services
{
    /// <summary>
    /// Service 1
    /// </summary>
    class CarInfoService : IService
    {
        private readonly List<IMovable> _transport;
        private readonly IConsoleOutput _consoleOutput;

        public CarInfoService(List<IMovable> transport, IConsoleOutput consoleOutput)
        {
            _transport = transport;
            _consoleOutput = consoleOutput;
        }

        public void RunService()
        {
            foreach (var transport in _transport)
            {
                _consoleOutput.ShowMessage(transport.ToString());
            }
        }
    }
}
