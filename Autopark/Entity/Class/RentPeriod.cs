namespace Autopark.Entity.Class
{
    public class RentPeriod
    {
        public int hourNumber;
        public int dayNumber;
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
            get
            {
                return (weekNumber * 4 + dayNumber) * 24 + hourNumber;
            }
        }
    }
}
