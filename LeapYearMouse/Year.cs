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
            if (_year%100 == 0)
            {
                if (_year%400 == 0)
                {
                    return true;
                }
                return false;
            }
            if (_year%4 == 0)
            {
                return true;
            }
            return false;
        }
    }
}