using Autopark.Entity.Class;
using Autopark.Entity.Enum;
using System.ComponentModel.DataAnnotations;

namespace Autopark.FactoryMethod.AbstractCreator
{
    /// <summary>
    /// Base class for create transport
    /// </summary>
    public abstract class Creator
    {
        /// <summary>
        /// Has info about producer country
        /// </summary>
        /// <param name="producerCountry">Name produce country</param>
        protected Creator(string producerCountry)
        {
            ProducerCountry = producerCountry;
        }

        [MaxLength(100)]
        public abstract string ProducerCountry { get; set; }

        /// <summary>
        /// Method for create Transport
        /// </summary>
        /// <param name="id">Transport Id</param>
        /// <param name="colorType">Transport color type </param>
        /// <param name="rentPeriod">Transport rent period</param>
        /// <param name="weight">Transport weight</param>
        /// <param name="cost">Transport cost</param>
        /// <param name="mileage">Transport mileage</param>
        /// <param name="totalFuelCapacity">Transport total fuel capacity</param>
        /// <returns>IMovable object</returns>
        public abstract Vehicle CreateVehicle(
            int id,
            ColorType colorType,
            RentPeriod rentPeriod,
            long weight,
            decimal cost,
            int mileage,
            int totalFuelCapacity,
            string brand);
    }
}
