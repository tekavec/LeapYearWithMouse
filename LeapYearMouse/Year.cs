namespace LeapYearMouse
{
    public class Year
    {
        private readonly int _year;

        public Year(int year)
        {
            _year = year;
        }

        public bool IsLeapYear()
        {
            return _year%100 == 0 ? _year%400 == 0 : IsDivisibleBy();
        }

        private bool IsDivisibleBy()
        {
            return _year % 4 == 0;
        }
    }
}