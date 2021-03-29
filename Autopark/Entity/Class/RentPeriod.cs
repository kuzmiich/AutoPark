namespace Autopark.Entity.Class
{
    public class RentPeriod
    {
        public RentPeriod()
        {
        }

        public RentPeriod(int hoursCount)
        {
            HoutNumber = hoursCount;
        }

        public RentPeriod(int hoursCount, int dayCount) : this(hoursCount)
        {
            DayNumber = dayCount;
        }

        public RentPeriod(int hourCount, int dayCount, int weekCount) : this(hourCount, dayCount)
        {
            WeekCount = weekCount;
        }

        public int HoutNumber { get; set; }
        public int DayNumber { get; set; }
        public int WeekCount { get; set; }

        public int GetHourNumber()
        {
            int hourNumber = HoutNumber;
            if (DayNumber > 0)
            {
                hourNumber += DayNumber * 24;
            }
            else if (WeekCount > 0)
            {
                hourNumber += WeekCount * 7;
            }
            return hourNumber;
        }
    }
}
