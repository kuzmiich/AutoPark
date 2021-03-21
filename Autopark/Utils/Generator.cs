using Autopark.FactorMethod.CreateArea;
using Autopark.FactoryMethod.BaseProduct;
using Autopark.FactoryMethod.Utils;
using Autopark.InputService.ConsoleInput;
using Autopark.OutputService.ConsoleOutput;
using System;
using System.Collections.Generic;

namespace Autopark.Utils
{
    public class Generator
    {
        private readonly Random _random = new Random();
        private readonly IConsoleOutput _outputService;
        private readonly IConsoleInput _inputService;

        private static List<string> PRODUCER_CONTRIES = new List<string>
        {
            "Japan",
            "China",
            "Russia",
            "USA",
            "Canada",
            "Germany",
            "India"
        };
        private static IEnumerable<string> Colors = new List<string>
        {
            ColorType.Black.ToString(),
            ColorType.Red.ToString(),
            ColorType.Black.ToString(),
            ColorType.Black.ToString(),
            ColorType.Black.ToString(),
        };

        public Generator(IConsoleOutput outputService, IConsoleInput inputService)
        {
            _outputService = outputService;
            _inputService = inputService;
        }

        public bool GetNumber(out int number, string message)
        {
            _outputService.ShowMessage(message);
            return int.TryParse(_inputService.GetString(), out number);
        }

        public ICollection<IMovable> GetTransport(int count)
        {
            List<IMovable> movables;
            DateTime rentDate = DateTime.Now;

            int index = _random.Next(PRODUCER_CONTRIES.Count);
            for (int i = 1; i < count + 1; i++)
            {
                if (i < count / 2)
                {
                    TruckCreator truckCreator = new TruckCreator(PRODUCER_CONTRIES[index]);
                    Truck truck = truckCreator.Create(i, ColorType, rentDate);
                }
                else
                {

                }
            }
            MotoCarCreator carCreator = new MotoCarCreator("Japan");

            return movables;
        }
    }
}
