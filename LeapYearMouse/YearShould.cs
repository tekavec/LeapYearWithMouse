using NUnit.Framework;

namespace LeapYearMouse
{
    public class YearShould
    {
        [Test]
        public void not_be_a_leap_year_if_it_is_not_divisible_by_4()
        {
            Assert.IsFalse(new Year(1997).IsLeapYear());
        }
    }

    public class Year
    {
        public Year(int year)
        {
        }

        public bool IsLeapYear()
        {
            return false;
        }
    }
}
