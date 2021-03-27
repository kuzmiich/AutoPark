using Autopark.Utils.Entity;
using System.Collections.Generic;

namespace Autopark.Utils.Engines.Base
{
    public abstract class AbstractEngine
    {
        public AbstractEngine(List<Vehicle> transport)
        {
            Transport = transport;
        }

        public abstract List<Vehicle> Transport { get; init; }
    }
}
