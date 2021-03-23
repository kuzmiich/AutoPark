using AutoPark.Controller;
using AutoPark.InputService.ConsoleInput;
using AutoPark.OutputService.ConsoleOutput;
using AutoPark.Utils;

namespace AutoPark
{
    public class Program
    {
        private static readonly IConsoleInput _consoleInput = ConsoleInput.GetInstance();
        private static readonly IConsoleOutput _consoleOutput = ConsoleOutput.GetInstance();
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
