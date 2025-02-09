﻿using System;

namespace Autopark.View.ConsoleOutput
{
    public class ConsoleOutput : IOutputService
    {
        private static readonly object _syncRoot = new();
        private static ConsoleOutput _instance;

        public static ConsoleOutput GetInstance()
        {
            if (_instance == null)
            {
                lock (_syncRoot)
                {
                    if (_instance == null)
                    {
                        _instance = new ConsoleOutput();
                    }
                }
            }
            return _instance;
        }

        private ConsoleOutput()
        {
        }

        public void ShowMessage(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
