using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeChallenges.Algorithms___HackerRank.com.Implementation.Easy.Tests
{
    [TestClass()]
    public class KangarooTests
    {
        [TestMethod()]
        public void TestCase0()
        {
            int x1 = 0;
            int x2 = 4;
            int v1 = 3;
            int v2 = 2;
            string expected = "YES";
            string result = Kangaroo.kangaroo(x1, v1, x2, v2);

            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void TestCase1()
        {
            int x1 = 0;
            int x2 = 5;
            int v1 = 2;
            int v2 = 3;
            string expected = "NO";
            string result = Kangaroo.kangaroo(x1, v1, x2, v2);

            Assert.AreEqual(expected, result);
        }
    }
}