using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeChallenges.Algorithms___HackerRank.com.WarmUp.Easy.Tests
{
    [TestClass()]
    public class DiagonalDifferenceTests
    {
        [TestMethod()]
        public void TestCase0()
        {
            int[][] array = { };
            int expected = 15;
            int result = DiagonalDifference.diagonalDifference(array);

            Assert.AreEqual(expected, result);
        }
    }
}