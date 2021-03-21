using Autopark.FactoryMethod.Utils;
using Autopark.OutputService.ConsoleOutput;
using Autopark.Utils;
using System;
using System.Collections.Generic;

namespace Autopark.Controller.Services
{
    /// <summary>
    /// Service 3
    /// </summary>
    class LeasingService : IService
    {
        private readonly List<IMovable> _transport;
        private readonly IConsoleOutput _outputService;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="transport"></param>
        /// <param name="outputService"></param>
        public LeasingService(List<IMovable> transport, IConsoleOutput outputService)
        {
            _transport = transport;
            _outputService = outputService;
        }


        /// <summary>
        /// 
        /// </summary>
        public void RunService()
        {
            throw new NotImplementedException();
        }
    }
}
