namespace Autopark.Entity.Class
{
    public class RentPeriod
    {
        public RentPeriod()
        {
        }

        public RentPeriod(int hoursCount)
        {
            HourCount = hoursCount;
        }

        public RentPeriod(int hoursCount, int dayCount) : this(hoursCount)
        {
            DayCount = dayCount;
        }

        public RentPeriod(int hourCount, int dayCount, int weekCount) : this(hourCount, dayCount)
        {
            WeekCount = weekCount;
        }

        public int HourCount { get; set; }
        public int DayCount { get; set; }
        public int WeekCount { get; set; }

        public int GetHourNumber()
        {
            int hourNumber = HourCount;
            if (DayCount > 0)
            {
                hourNumber += DayCount * 24;
            }
            else if (WeekCount > 0)
            {
                hourNumber += WeekCount * 7;
            }
            return hourNumber;
        }
    }
}
