using Autopark.Model.Entity;
using Autopark.Model.Enum;
using System;
using System.Collections.Generic;

namespace Autopark.Services.Model
{
    class Validator
    {
        private bool _isValidate = false;

        public Validator()
        {

        }

        public Validator TypeCharacter(VehicleType type)
        {
            if (type == VehicleType.MotorCar)
            {
                _isValidate = true;
            }
            else if (type == VehicleType.Truck)
            {
                _isValidate = true;
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
