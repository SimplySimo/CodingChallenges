using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeChallenges.Algorithms___HackerRank.com.WarmUp.Easy.Tests
{
    [TestClass()]
    public class BirthdayCakeCandlesTests
    {
        [TestMethod()]
        public void birthdayCakeCandlesTest()
        {
            int[] array1 = { 3, 2, 1, 3 };
            int expected = 2;
            int result = BirthdayCakeCandles.birthdayCakeCandles(array1);

            Assert.AreEqual(expected, result);
        }
    }
}