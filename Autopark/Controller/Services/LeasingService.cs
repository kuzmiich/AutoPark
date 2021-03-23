using AutoPark.FactoryMethod.Utils;
using AutoPark.OutputService.ConsoleOutput;
using AutoPark.Utils;
using System;
using System.Collections.Generic;

namespace AutoPark.Controller.Services
{
    /// <summary>
    /// Service 3
    /// </summary>
    class LeasingService : IService
    {
        private readonly List<IMovable> _transport;
        private readonly IConsoleOutput _consoleOutput;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="transport"></param>
        /// <param name="consoleOutput"></param>
        public LeasingService(List<IMovable> transport, IConsoleOutput consoleOutput)
        {
            _transport = transport;
            _consoleOutput = consoleOutput;
        }


        /// <summary>
        /// 
        /// </summary>
        public void RunService()
        {
            Console.WriteLine();
        }
    }
}
