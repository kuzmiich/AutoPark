using Autopark.Entity.Class;
using Autopark.Services.Model.Extension.DataAnnotation;
using System.Collections.Generic;

namespace Autopark.Model.Extension
{
    static class ContolValidationExtension
    {
        public static Validator Rules(this List<Vehicle> vehicles) => new Validator();
    }
}
