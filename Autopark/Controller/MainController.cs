using AutoPark.Controller.Services;
using AutoPark.FactoryMethod.Utils;
using AutoPark.InputService.ConsoleInput;
using AutoPark.OutputService.ConsoleOutput;
using AutoPark.Utils;
using System;
using System.Collections.Generic;

namespace AutoPark.Controller
{
    public class MainController
    {
        public IConsoleInput InputService { get; init; }
        public IConsoleOutput OutputService { get; init; }
        public IGenerator Generator { get; init; }
        public List<IMovable> Transport { get; set; }

        public MainController(IConsoleInput inputService, IConsoleOutput outputService, IGenerator generator)
        {
            InputService = inputService;
            OutputService = outputService;
            Generator = generator;
        }

        public void StartController()
        {
            OutputService.ShowMessage("Input count of car in the autopark:");
            var carNumber = Convert.ToInt32(InputService.GetString());

            Transport = Generator.GetMotoCars(carNumber);

            List<IService> services = new List<IService>
            {
                new AutoparkInfoService(Transport, OutputService),
                new CarInfoService(Transport, OutputService),
                new LeasingService(Transport, OutputService)
            };

            try
            {
                foreach (var service in services)
                {
                    service.RunService();
                }
            }
            catch (Exception ex)
            {
                OutputService.ShowMessage(ex.Message);
            }

        }
    }
}