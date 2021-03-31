using System;
using System.Runtime.Serialization;

namespace Autopark.Services.Model.ModelException
{
    [Serializable]
    internal class VehicleTypeValidateException : Exception
    {
        public VehicleTypeValidateException()
        {
        }

        public VehicleTypeValidateException(string message) : base(message)
        {
        }

        public VehicleTypeValidateException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected VehicleTypeValidateException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}