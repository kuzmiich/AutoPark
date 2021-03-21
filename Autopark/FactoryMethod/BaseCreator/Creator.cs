using Autopark.FactoryMethod.Utils;
using System;

namespace Autopark.FactorMethod.BaseCreator
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

        abstract public IMovable Create(int id,
            ColorType colorType,
            DateTime rentDate,
            long weight,
            decimal cost);
    }
}
