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
            return IsDivisibleBy(IsDivisibleBy(100) ? 400 : 4);
        }

        private bool IsDivisibleBy(int value)
        {
            return _year % value == 0;
        }
    }
}