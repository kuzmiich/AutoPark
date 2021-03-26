using AutoPark.Controller.Services;
using AutoPark.InputService;
using AutoPark.Models.Engine;
using AutoPark.Models.Utils.Entity;
using AutoPark.Models.Utils.Interfaces;
using AutoPark.OutputService;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AutoPark.Controller
{
    public class MainController
    {
        public IInputService InputService { get; init; }
        public IOutputService OutputService { get; init; }
        public IGenerator Generator { get; init; }
        public List<Vehicle> Transport { get; set; }

        public MainController(IInputService inputService, IOutputService outputService, IGenerator generator)
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
            Transport.Zip(Generator.GetTruck(carNumber));

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