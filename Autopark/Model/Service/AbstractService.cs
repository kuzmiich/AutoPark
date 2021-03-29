using Autopark.Entity.Class;
using System.Collections.Generic;

namespace Autopark.Model.Service
{
    public abstract class AbstractService
    {
        public AbstractService(List<Vehicle> transport)
        {
            Transport = transport;
        }

        public abstract List<Vehicle> Transport { get; init; }
    }
}
