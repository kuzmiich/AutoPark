using AutoPark.Utils.Utils.Interfaces;
using System;

namespace AutoPark.Services.InputService.ConsoleInput
{
    public class ConsoleInput : IInputService
    {
        private static readonly object _syncRoot = new();
        private static ConsoleInput _instance;

        private ConsoleInput()
        {

        }

        public static ConsoleInput GetInstance()
        {
            if (_instance == null)
            {
                lock (_syncRoot)
                {
                    if (_instance == null)
                    {
                        _instance = new ConsoleInput();
                    }
                }
            }
            return _instance;
        }

        public string GetString()
        {
            return Console.ReadLine();
        }
    }
}
