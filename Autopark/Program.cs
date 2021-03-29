using Autopark.Controller;
using Autopark.Model.Service;
using Autopark.Model.Service.GenerationService;
using Autopark.Model.Service.InputService;
using Autopark.Model.Service.InputService.ConsoleInput;
using Autopark.View;
using Autopark.View.ConsoleOutput;

namespace Autopark
{
    public class Program
    {
        private static readonly IInputService _consoleInput = ConsoleInput.GetInstance();
        private static readonly IOutputService _consoleOutput = ConsoleOutput.GetInstance();
        private static readonly IGenerationService _generator = new VehicleGeneration();

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
