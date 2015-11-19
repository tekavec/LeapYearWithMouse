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

        [Test]
        public void be_a_leap_year_if_it_is_divisible_by_4()
        {
            Assert.IsTrue(new Year(1996).IsLeapYear());
        }
    }
}
