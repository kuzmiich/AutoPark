using Autopark.Model.Entity;
using Autopark.Model.Enum;
using Autopark.Services.Model;
using System.Collections.Generic;

namespace Autopark.Model.Extension
{
    static class ContolValidationExtension
    {
        public static Validator Rules(this List<Vehicle> vehicles) => new Validator();
    }
}
