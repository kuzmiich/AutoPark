using System;
using System.Collections.Generic;

namespace Autopark.Entity.Const
{
    public static class VehicleBrand
    {
        public const string Lamborghini = "Lamborghini";
        public const string Lada = "Lada";

        public static List<string> CarBrand => new()
        {
            Lada,
            Lamborghini
        };

        public const string Zil = "Zil";
        public const string Man = "Man";

        public static List<string> TruckBrand => new() 
        { 
            Zil
        };
    }
}
