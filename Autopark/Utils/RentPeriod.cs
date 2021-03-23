namespace AutoPark.Utils
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

        public RentPeriod(int hoursCount, int dayCount, int weekCount)
        {
            HourCount = hoursCount;
            DayCount = dayCount;
            WeekCount = weekCount;
        }

        public int HourCount { get; set; }
        public int DayCount { get; set; }
        public int WeekCount { get; set; }
    }
}
