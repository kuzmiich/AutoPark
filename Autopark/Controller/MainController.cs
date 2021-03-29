using Autopark.Controller.AutoparkController;
using Autopark.Entity.Class;
using Autopark.Model.Service;
using Autopark.Model.Service.InputService;
using Autopark.View;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Autopark.Controller
{
    public class MainController : IContoller
    {
        public IInputService InputService { get; init; }
        public IOutputService OutputService { get; init; }
        public IGenerationService Generator { get; init; }
        public List<Vehicle> Transport { get; set; }

        public MainController(IInputService inputService, IOutputService outputService, IGenerationService generator)
        {
            InputService = inputService;
            OutputService = outputService;
            Generator = generator;
        }

        public void RunController()
        {
            OutputService.ShowMessage("Input count of car in the autopark:"); 
            var vehicleNumber = 0;
            try
            {
                vehicleNumber = Convert.ToInt32(InputService.GetString());
            }
            catch
            {
                throw new ArgumentException("Error, input number.");
            }
            Transport = Generator.GetMotoCars(vehicleNumber);
            Transport.Zip(Generator.GetTrucks(vehicleNumber));

            var controllers = new List<IContoller>
            {
                new AutoparkInfoController(Transport, OutputService),
                new VehicleInfoController(Transport, OutputService),
                new LeasingController(Transport, OutputService),
                new ParkingController(Transport, OutputService)
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