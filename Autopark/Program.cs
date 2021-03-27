using AutoPark.Controllers;
using AutoPark.Utils.Utils.Interfaces;
using AutoPark.Services;
using AutoPark.Services.InputService.ConsoleInput;
using AutoPark.Services.OutputService.ConsoleOutput;

namespace AutoPark
{
    public class Program
    {
        private static readonly IInputService _consoleInput = ConsoleInput.GetInstance();
        private static readonly IOutputService _consoleOutput = ConsoleOutput.GetInstance();
        private static readonly IGeneratorService _generator = Generator.GetInstance();

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
