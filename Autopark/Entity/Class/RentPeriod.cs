using Autopark.Entity.Const;
using System.ComponentModel.DataAnnotations;

namespace Autopark.Entity.Class
{
    public class RentPeriod
    {
        [Range(1, RentCoef.MaxHourOfDay)]
        public int hourNumber;

        [Range(1, RentCoef.MaxDayOfWeek)]
        public int dayNumber;

        [Range(1, RentCoef.MaxWeekOfMonth)]
        public int weekNumber;

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

        public int HourNumber { 
            get => (weekNumber * RentCoef.MaxWeekOfMonth + dayNumber) * RentCoef.MaxHourOfDay + hourNumber;
        }
    }
}
