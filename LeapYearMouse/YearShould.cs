using NUnit.Framework;

namespace LeapYearMouse
{
    [TestFixture]
    public class YearShould
    {

        [Test]
        public void not_be_a_leap_year_if_not_divisible_by_4()
        {
            Assert.IsFalse(IsLeapYear(1997));
        }

        [Test]
        public void be_a_leap_year_if_divisible_by_4()
        {
            Assert.IsTrue(IsLeapYear(1996));
        }

        private static bool IsLeapYear(int year)
        {
            return new Year(year).IsLeapYear();
        }

        [Test]
        public void be_a_leap_year_if_divisible_by_400()
        {
            Assert.IsTrue(IsLeapYear(1600));
        }

        [Test]
        public void not_be_a_leap_year_if_divisible_by_100_but_not_by_400()
        {
            Assert.IsFalse(IsLeapYear(1800));
        }
    }
}