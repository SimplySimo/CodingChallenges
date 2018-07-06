using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeChallenges.Algorithms___HackerRank.com.WarmUp.Easy.Tests
{
    [TestClass()]
    public class TimeConversionTests
    {
        [TestMethod()]
        public void timeConversionTest()
        {
            string input = "07:05:45PM";
            string expected = "19:05:45";
            string result = TimeConversion.timeConversion(input);

            Assert.AreEqual(expected, result);
        }
    }
}