using Autopark.InputService;
using Autopark.Model.Entity;
using Autopark.Model.Services.Base;
using Autopark.OutputService;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Autopark.Controller
{
    public class MainController : IContoller
    {
        public IInputService InputService { get; init; }
        public IOutputService OutputService { get; init; }
        public IGeneratorService Generator { get; init; }
        public List<Vehicle> Transport { get; set; }

        public MainController(IInputService inputService, IOutputService outputService, IGeneratorService generator)
        {
            InputService = inputService;
            OutputService = outputService;
            Generator = generator;
        }

        public void RunController()
        {
            OutputService.ShowMessage("Input count of car in the autopark:");
            var carNumber = Convert.ToInt32(InputService.GetString());

            Transport = Generator.GetMotoCars(carNumber);
            Transport.Zip(Generator.GetTrucks(carNumber));

            var controllers = new List<IContoller>
            {
                new AutoparkInfoController(Transport, OutputService),
                new CarInfoController(Transport, OutputService),
                new LeasingController(Transport, OutputService)
            };

            try
            {
                foreach (var controller in controllers)
                {
                    controller.RunController();
                }
            }
            catch (Exception ex)
            {
                OutputService.ShowMessage(ex.Message);
            }

        }
    }
}