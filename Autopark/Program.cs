using Autopark.Controller;
using Autopark.Controller.Services;
using Autopark.InputService.ConsoleInput;
using Autopark.OutputService.ConsoleOutput;
using Autopark.Utils;
using System.Collections.Generic;

namespace Autopark
{
    public class Program
    {
        private static readonly IConsoleInput _inputService = ConsoleInput.GetInstance();
        private static readonly IConsoleOutput _outputService = ConsoleOutput.GetInstance();

        static void Main(string[] args)
        {
            List<IService> services = new List<IService>
            {
                new AutoparkInfoService(),

            };

        }
    }
}
