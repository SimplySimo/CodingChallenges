using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeChallenges.Algorithms___HackerRank.com.WarmUp.Easy.Tests
{
    [TestClass()]
    public class CompareTheTriplesTests
    {
        [TestMethod()]
        public void TestCase0()
        {
            int[] array1 = { 5,6,7};
            int[] array2 = { 3, 6, 10 };
            int[] expected = { 1, 1 };
            int[] result = CompareTheTriples.solve(array1, array2);

            CollectionAssert.AreEqual(expected, result);
        }
    }
}