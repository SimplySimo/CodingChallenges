using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeChallenges.Algorithms___HackerRank.com.WarmUp.Easy.Tests
{
    [TestClass()]
    public class AVeryBigSumTests
    {
        [TestMethod()]
        public void TestCase0()
        {
            long[] array1 = { 1000000001, 1000000002, 1000000003, 1000000004, 1000000005 };
            long expected = 5000000015;
            long result = AVeryBigSum.aVeryBigSum(array1);

            Assert.AreEqual(expected, result);
        }
    }
}