using AutoPark.Controller;
using AutoPark.InputService;
using AutoPark.InputService.ConsoleInput;
using AutoPark.Models.Utils;
using AutoPark.Models.Utils.Interfaces;
using AutoPark.OutputService;
using AutoPark.OutputService.ConsoleOutput;

namespace AutoPark
{
    public class Program
    {
        private static readonly IInputService _consoleInput = ConsoleInput.GetInstance();
        private static readonly IOutputService _consoleOutput = ConsoleOutput.GetInstance();
        private static readonly IGenerator _generator = Generator.GetInstance();

        static void Main(string[] args)
        {
            MainController controller = new(
                _consoleInput,
                _consoleOutput,
                _generator
            );
            controller.StartController();
        }
    }
}
