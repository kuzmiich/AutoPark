using Autopark.Controller;
using Autopark.Controller.AutoparkController;
using Autopark.Entity.Class;
using Autopark.InputService;
using Autopark.Model.Service;
using Autopark.Model.Service.GenerationService;
using Autopark.View;
using Autopark.View.ConsoleOutput;
using AutoparkInputService.ConsoleInput;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Autopark
{
    public class Program
    {
        private static readonly IInputService _consoleInput = ConsoleInput.GetInstance();
        private static readonly IOutputService _consoleOutput = ConsoleOutput.GetInstance();
        private static readonly IGenerationService _generator = new VehicleGeneration();

        static void Main(string[] args)
        {

            _consoleOutput.ShowMessage("Input count of car in the autopark:");
            var vehicleNumber = 0;
            try
            {
                vehicleNumber = Convert.ToInt32(_consoleInput.GetString());
            }
            catch
            {
                throw new ArgumentException("Error, input number.");
            }

            List<Vehicle> listMotoCarsAndTrucks = _generator.GetCars(vehicleNumber).Union(_generator.GetTrucks(vehicleNumber)).ToList();

            var controllers = new List<IContoller>
            {
                new AutoparkInfoController(listMotoCarsAndTrucks, _consoleOutput),
                new VehicleInfoController(listMotoCarsAndTrucks, _consoleOutput),
                new LeasingController(listMotoCarsAndTrucks, _consoleOutput),
                new ParkingController(listMotoCarsAndTrucks, _consoleOutput)
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
                _consoleOutput.ShowMessage(ex.Message);
            }
        }

    }
}
