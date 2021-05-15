using Autopark.Entity.Const;
using System.ComponentModel.DataAnnotations;

namespace Autopark.Entity.Class
{
    public class RentPeriod
    {
        [Range(0, RentCoef.MaxHourOfDay)]
        private int _hourNumber;

        [Range(0, RentCoef.MaxDayOfWeek)]
        private int _dayNumber;

        [Range(0, RentCoef.MaxWeekOfMonth)]
        private int _weekNumber;

        #region Constructors
        public RentPeriod()
        {
        }

        public RentPeriod(int hourNumber)
        {
            _hourNumber = hourNumber;
        }

        public RentPeriod(int hourNumber, int dayNumber) : this(hourNumber)
        {
            _dayNumber = dayNumber;
        }

        public RentPeriod(int hourNumber, int dayCount, int weekNumber) : this(hourNumber, dayCount)
        {
            _weekNumber = weekNumber;
        }
        #endregion

        [Range(0, int.MaxValue)]
        public int HourNumber => (_weekNumber * RentCoef.MaxWeekOfMonth + _dayNumber) * RentCoef.MaxHourOfDay + _hourNumber;
    }
}
