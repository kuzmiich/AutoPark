namespace AutoPark.Utils.Entity
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
    }
}
