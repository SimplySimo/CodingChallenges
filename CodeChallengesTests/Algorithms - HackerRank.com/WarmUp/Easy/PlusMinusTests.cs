using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeChallenges.Algorithms___HackerRank.com.WarmUp.Easy.Tests
{
    [TestClass()]
    public class PlusMinusTests
    {
        [TestMethod()]
        public void plusMinusTest()
        {
            int[] array1 = { -4, 3, -9, 0, 4, 1 };
            double[] expected = { 0.500000, 0.333333, 0.166667 };
            double[] result = PlusMinus.plusMinus(array1);

            CollectionAssert.AreEqual(expected, result);
        }
    }
}