using Autopark.Controller;
using Autopark.Controller.AutoparkController;
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
            var listVehicle = _generator.GetMotoCars(vehicleNumber);
            listVehicle.Zip(_generator.GetTrucks(vehicleNumber));

            var controllers = new List<IContoller>
            {
                new AutoparkInfoController(listVehicle, _consoleOutput),
                new VehicleInfoController(listVehicle, _consoleOutput),
                new LeasingController(listVehicle, _consoleOutput),
                new ParkingController(listVehicle, _consoleOutput)
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
