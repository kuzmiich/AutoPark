using Autopark.Entity.Enum;
using System;
using System.Linq;

namespace Autopark.Services.Model
{
    class Validator
    {
        private bool _isValidate = false;

        public Validator()
        {

        }

        public Validator TypeCharacter(VehicleType vehicleType)
        {
            var arrayVehicleType = Enum.GetValues(typeof(VehicleType)).Cast<VehicleType>();
            foreach (var type in arrayVehicleType)
            {
                if(vehicleType == type)
                {
                    _isValidate = true;
                }
            }
            return this;
        }

        public void Validate()
        {
            if (_isValidate == false)
            {
                throw new VehicleTypeValidateException("Error, incorrectly passed machine type");
            }
        }
    }
}
