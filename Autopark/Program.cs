using Autopark.Controller;
using Autopark.InputService;
using Autopark.InputService.ConsoleInput;
using Autopark.Model.Services;
using Autopark.Model.Services.Base;
using Autopark.OutputService;
using Autopark.OutputService.ConsoleOutput;

namespace Autopark
{
    public class Program
    {
        private static readonly IInputService _consoleInput = ConsoleInput.GetInstance();
        private static readonly IOutputService _consoleOutput = ConsoleOutput.GetInstance();
        private static readonly IGeneratorService _generator = new GenerateService();

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
