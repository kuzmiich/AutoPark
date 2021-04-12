using Autopark.Entity.Const;
using System.ComponentModel.DataAnnotations;

namespace Autopark.Entity.Class
{
    public class RentPeriod
    {
        [Range(0, RentCoef.MaxHourOfDay)]
        public int hourNumber { get; set; }

        [Range(0, RentCoef.MaxDayOfWeek)]
        public int dayNumber { get; set; }

        [Range(0, RentCoef.MaxWeekOfMonth)]
        public int weekNumber { get; set; }

        #region Constructors
        public RentPeriod()
        {
        }

        public RentPeriod(int hourNumber)
        {
            this.hourNumber = hourNumber;
        }

        public RentPeriod(int hourNumber, int dayNumber) : this(hourNumber)
        {
            this.dayNumber = dayNumber;
        }

        public RentPeriod(int hourNumber, int dayCount, int weekNumber) : this(hourNumber, dayCount)
        {
            this.weekNumber = weekNumber;
        }
        #endregion

        [Range(0, int.MaxValue)]
        public int HourNumber => (weekNumber * RentCoef.MaxWeekOfMonth + dayNumber) * RentCoef.MaxHourOfDay + hourNumber;
    }
}
