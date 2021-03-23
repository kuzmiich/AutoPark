using AutoPark.FactoryMethod.Utils;
using AutoPark.Utils;
using System;

namespace AutoPark.FactorMethod.BaseCreator
{
    /// <summary>
    /// Base class for create transport
    /// </summary>
    abstract class Creator
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="producerCountry"></param>
        protected Creator(string producerCountry)
        {
            ProducerCountry = producerCountry;
        }

        public abstract string ProducerCountry { get; set; }

        abstract public IMovable Create(
            int id,
            ColorType colorType,
            RentPeriod rentDate,
            long weight,
            decimal cost);
    }
}
