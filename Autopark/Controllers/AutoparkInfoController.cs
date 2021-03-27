﻿using Autopark.Models.Engines;
using Autopark.Utils.Engines;
using Autopark.Utils.Entity;
using Autopark.Utils.Enums;
using Autopark.Utils.Utils.Interfaces;
using System;
using System.Collections.Generic;

namespace Autopark.Controllers
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
            Engine = new AutoParkEngine(Transport);
        }

        public List<Vehicle> Transport { get; }
        public IOutputService OutputService { get; }
        private AutoParkEngine Engine { get; set; }

        public void RunController()
        {
            OutputService.ShowMessage($"Autopark cost - {Engine.AutoparkCost}");
            OutputService.ShowMessage($"Autopark square - {Engine.AutoparkSquare}");

            Engine.BuyVehicle(Transport, 2, VehicleType.Truck);

            Engine.SortByCost();
            OutputService.ShowMessage(string.Join('\n', Transport));
            OutputService.ShowMessage(string.Empty.PadLeft(150, '-'));

            Engine.SortByCostRent();
            OutputService.ShowMessage(string.Join('\n', Transport));
            OutputService.ShowMessage(string.Empty.PadLeft(150, '-'));

            Engine.SortByTotalFuelCapacity();
            OutputService.ShowMessage(string.Join('\n', Transport));
            OutputService.ShowMessage(string.Empty.PadLeft(150, '-'));
        }
    }
}
