using Autopark.Entity.Class;
using Autopark.Entity.Enum;
using Autopark.Model.Service;
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
        }

        private List<Vehicle> _transport;
        private static IOutputService _consoleOutput;
        private static readonly IAutoparkInfoService _autoparkInfoService = new AutoparkInfoService();

        public void RunController()
        {
            _consoleOutput.ShowMessage($"Autopark cost - {AutoparkInfoService.autoparkCost}");
            _consoleOutput.ShowMessage($"Autopark square - {AutoparkInfoService.autoparkSquare}");

            _consoleOutput.ShowMessage($"Total vehicle cost - {AutoparkInfoService.TotalVehicleCost(_transport)}");
            _consoleOutput.ShowMessage(string.Empty.PadLeft(150, '-'));

            _autoparkInfoService.BuyVehicle(_transport, 4, VehicleType.Truck);
            _consoleOutput.ShowMessage($"Buy 4 vehicle. Vehicle count - {_transport.Count}");

            _autoparkInfoService.SellVehicle(_transport, 2);
            _consoleOutput.ShowMessage($"Sell 2 vehicle. Vehicle count - {_transport.Count}");

            _consoleOutput.ShowMessage($"Sort by Id: \n{string.Join('\n', AutoparkInfoService.SortByCreteria(_transport, SortingCriteriaType.Id))}");
            _consoleOutput.ShowMessage(string.Empty.PadLeft(150, '-'));
        }
    }
}
