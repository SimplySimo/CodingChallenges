using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeChallenges.Algorithms___HackerRank.com.Implementation.Easy.Tests
{
    [TestClass()]
    public class BreakingTheRecordsTests
    {
        [TestMethod()]
        public void Testcase0()
        {
            int[] array = { 10, 5, 20, 20, 4, 5, 2, 25, 1 };
            int[] expected = {2,4 };
            int[] result = BreakingTheRecords.breakingRecords(array);

            CollectionAssert.AreEqual(expected, result);
        }
        [TestMethod()]
        public void Testcase1()
        {
            int[] array = { 3, 4, 21, 36, 10, 28, 35, 5, 24, 42 };
            int[] expected = { 4, 0 };
            int[] result = BreakingTheRecords.breakingRecords(array);

            CollectionAssert.AreEqual(expected, result);
        }
    }
}