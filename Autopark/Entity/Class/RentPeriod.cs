namespace Autopark.Entity.Class
{
    public class RentPeriod
    {
        #region Constructors
        public RentPeriod()
        {
        }

        public RentPeriod(int hoursNumber)
        {
            HourNumber = hoursNumber;
        }

        public RentPeriod(int hoursCount, int dayNumber) : this(hoursCount)
        {
            DayNumber = dayNumber;
        }

        public RentPeriod(int hourCount, int dayCount, int weekNumber) : this(hourCount, dayCount)
        {
            WeekNumber = weekNumber;
        }
        #endregion

        public int HourNumber { get; init; }

        public int DayNumber { 
            get
            {
                return HourNumber * 24;
            }
            set { } 
        }
        public int WeekNumber { 
            get
            {
                return HourNumber * 7;
            }
            set { } 
        }

        public int GetHourNumber()
        {
            return HourNumber + DayNumber + WeekNumber;
        }
    }
}
