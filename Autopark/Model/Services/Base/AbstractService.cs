using Autopark.Model.Entity;
using System.Collections.Generic;

namespace Autopark.Model.Services.Base
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
