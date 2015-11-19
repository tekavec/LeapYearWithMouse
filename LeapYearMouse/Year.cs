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
            if (IsDivisibleBy(100))
            {
                if (IsDivisibleBy(400))
                {
                    return true;
                }
                return false;
            }
            if (IsDivisibleBy(4))
            {
                return true;
            }
            return false;
        }

        private bool IsDivisibleBy(int value)
        {
            return _year%value == 0;
        }
    }
}