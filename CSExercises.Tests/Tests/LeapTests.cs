using CSExercises.Attempts.Exercises;
using System;
using Xunit;

namespace CSExercises.Tests.Tests
{
    public class LeapTests
    {
        [Fact]
        public void Year_not_divisible_by_4_is_common_year()
        {
            Assert.False(Leap.IsLeapYear(2015));
        }

        [Fact]
        public void Year_divisible_by_4_not_divisible_by_100_is_leap_year()
        {
            Assert.True(Leap.IsLeapYear(2016));
        }

        [Fact]
        public void Year_divisible_by_100_not_divisible_by_400_is_common_year()
        {
            Assert.False(Leap.IsLeapYear(2100));
        }

        [Fact]
        public void Year_divisible_by_400_is_leap_year()
        {
            Assert.True(Leap.IsLeapYear(2000));
        }
    }
}
