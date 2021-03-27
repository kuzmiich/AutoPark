using Autopark.Controllers;
using Autopark.Utils.Utils.Interfaces;
using Autopark.Services;
using Autopark.Services.InputService.ConsoleInput;
using Autopark.Services.OutputService.ConsoleOutput;

namespace Autopark
{
    public class Program
    {
        private static readonly IInputService _consoleInput = ConsoleInput.GetInstance();
        private static readonly IOutputService _consoleOutput = ConsoleOutput.GetInstance();
        private static readonly IGeneratorService _generator = new Generator();

        static void Main(string[] args)
        {
            MainController controller = new(
                _consoleInput,
                _consoleOutput,
                _generator
            );
            controller.RunController();
        }
    }
}
