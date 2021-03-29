using Autopark.Entity.Class;
using Autopark.Entity.Enum;
using Autopark.Model.Service.AutoperkService;
using Autopark.View;
using System.Collections.Generic;

namespace Autopark.Controller.AutoparkController
{
    /// <summary>
    /// Service 2 - Autopark Controller contain special information about company
    /// </summary>
    class AutoparkInfoController : IContoller
    {
        public AutoparkInfoController(List<Vehicle> transport, IOutputService consoleOutput)
        {
            Transport = transport;
            ConsoleOutput = consoleOutput;
            Engine = new AutoparkInfoService(Transport);
        }

        public List<Vehicle> Transport { get; }
        public IOutputService ConsoleOutput { get; }
        private AutoparkInfoService Engine { get; set; }

        public void RunController()
        {
            ConsoleOutput.ShowMessage($"Autopark cost - {AutoparkInfoService.autoparkCost}");
            ConsoleOutput.ShowMessage($"Autopark square - {AutoparkInfoService.autoparkSquare}");

            ConsoleOutput.ShowMessage($"Total vehicle cost - {Engine.TotalVehicleCost}");
            ConsoleOutput.ShowMessage(string.Empty.PadLeft(150, '-'));

            Engine.BuyVehicle(4, VehicleType.Truck);

            Engine.SellVehicle(2);

            Engine.SortByCost();
            ConsoleOutput.ShowMessage($"Sort by Cost: \n{string.Join('\n', Engine.Transport)}");
            ConsoleOutput.ShowMessage(string.Empty.PadLeft(150, '-'));

            Engine.SortById();
            ConsoleOutput.ShowMessage($"Sort by id: \n{string.Join('\n', Engine.Transport)}");
            ConsoleOutput.ShowMessage(string.Empty.PadLeft(150, '-'));

            Engine.SortByTotalFuelCapacity();
            ConsoleOutput.ShowMessage($"Sort by total fuel capacity: \n{string.Join('\n', Engine.Transport)}");
            ConsoleOutput.ShowMessage(string.Empty.PadLeft(150, '-'));
        }
    }
}
