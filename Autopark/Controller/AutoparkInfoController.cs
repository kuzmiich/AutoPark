using Autopark.Model.Entity;
using Autopark.Model.Enum;
using Autopark.Model.Services;
using Autopark.OutputService;
using System.Collections.Generic;

namespace Autopark.Controller
{
    /// <summary>
    /// Service 2 - Autopark Controller contain special information about company
    /// </summary>
    class AutoparkInfoController : IContoller
    {
        public AutoparkInfoController(List<Vehicle> transport, IOutputService consoleOutput)
        {
            Transport = transport;
            OutputService = consoleOutput;
            Engine = new AutoparkService(Transport);
        }

        public List<Vehicle> Transport { get; }
        public IOutputService OutputService { get; }
        private AutoparkService Engine { get; set; }

        public void RunController()
        {
            OutputService.ShowMessage($"Autopark cost - {Engine.AutoparkCost}");
            OutputService.ShowMessage($"Autopark square - {Engine.AutoparkSquare}");

            Engine.BuyVehicle(Transport, 2, VehicleType.Truck);

            Engine.SortByCost();
            OutputService.ShowMessage(string.Join('\n', Transport));
            OutputService.ShowMessage(string.Empty.PadLeft(150, '-'));

            Engine.SortById();
            OutputService.ShowMessage(string.Join('\n', Transport));
            OutputService.ShowMessage(string.Empty.PadLeft(150, '-'));

            Engine.SortByTotalFuelCapacity();
            OutputService.ShowMessage(string.Join('\n', Transport));
            OutputService.ShowMessage(string.Empty.PadLeft(150, '-'));
        }
    }
}
