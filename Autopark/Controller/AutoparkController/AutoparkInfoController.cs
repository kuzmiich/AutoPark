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
            _transport = transport;
            _consoleOutput = consoleOutput;
            _autoparkInfoService = new AutoparkInfoService(_transport);
        }

        private static List<Vehicle> _transport;
        private static IOutputService _consoleOutput;
        private static AutoparkInfoService _autoparkInfoService;

        public void RunController()
        {
            _consoleOutput.ShowMessage($"Autopark cost - {AutoparkInfoService.autoparkCost}");
            _consoleOutput.ShowMessage($"Autopark square - {AutoparkInfoService.autoparkSquare}");

            _consoleOutput.ShowMessage($"Total vehicle cost - {_autoparkInfoService.TotalVehicleCost}");
            _consoleOutput.ShowMessage(string.Empty.PadLeft(150, '-'));

            _autoparkInfoService.BuyVehicle(4, VehicleType.Truck);
            _consoleOutput.ShowMessage($"Buy 4 vehicle. Vehicle number - {_transport.Count}");

            _autoparkInfoService.SellVehicle(2);
            _consoleOutput.ShowMessage($"Sell 2 vehicle. Vehicle number - {_transport.Count}");

            _consoleOutput.ShowMessage($"Sort by Cost: \n{string.Join('\n', _autoparkInfoService.SortByCost())}");
            _consoleOutput.ShowMessage(string.Empty.PadLeft(150, '-'));

            _consoleOutput.ShowMessage($"Sort by id: \n{string.Join('\n', _autoparkInfoService.SortById())}");
            _consoleOutput.ShowMessage(string.Empty.PadLeft(150, '-'));

            _autoparkInfoService.SortByTotalFuelCapacity();
            _consoleOutput.ShowMessage($"Sort by total fuel capacity: \n{string.Join('\n', _autoparkInfoService.SortByTotalFuelCapacity())}");
            _consoleOutput.ShowMessage(string.Empty.PadLeft(150, '-'));
        }
    }
}
