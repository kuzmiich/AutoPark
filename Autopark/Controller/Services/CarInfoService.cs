using AutoPark.Models.Engine;
using AutoPark.Models.Utils.Entity;
using AutoPark.Models.Utils.Interfaces;
using AutoPark.OutputService;
using System.Collections.Generic;

namespace AutoPark.Controller.Services
{
    /// <summary>
    /// Service 1 - Common information about Vehicles
    /// </summary>
    class CarInfoService : IService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="transport"></param>
        /// <param name="consoleOutput"></param>
        public CarInfoService(List<Vehicle> transport, IOutputService consoleOutput)
        {
            Transport = transport;
            ConsoleOutput = consoleOutput;
            Engine = new AutoParkEngine(Transport);
        }

        public List<Vehicle> Transport { get; }
        public IOutputService ConsoleOutput { get; }
        private AutoParkEngine Engine { get; set; }

        public void RunService()
        {
            try
            {
                ConsoleOutput.ShowMessage($"Max mileage = {Engine.GetMaxMileage()}");
                ConsoleOutput.ShowMessage($"Min mileage = {Engine.GetMinMileage()}");
                ConsoleOutput.ShowMessage($"Total mileage = {Engine.GetTotalMileage()}");
                ConsoleOutput.ShowMessage($"Total weight = {Engine.GetTotalWeight()}");

                ConsoleOutput.ShowMessage(string.Empty.PadLeft(150, '-'));

                Engine.SortByCost();
                ConsoleOutput.ShowMessage(string.Join('\n', Transport));
                ConsoleOutput.ShowMessage(string.Empty.PadLeft(150, '-'));

                Engine.SortByCostRent();
                ConsoleOutput.ShowMessage(string.Join('\n', Transport));
                ConsoleOutput.ShowMessage(string.Empty.PadLeft(150, '-'));

                Engine.SortByTotalFuelCapacity();
                ConsoleOutput.ShowMessage(string.Join('\n', Transport));
                ConsoleOutput.ShowMessage(string.Empty.PadLeft(150, '-'));
            }
            catch
            {
                throw;
            }
        }
    }
}
