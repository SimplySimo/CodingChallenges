using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeChallenges.Algorithms___HackerRank.com.Implementation.Easy.Tests
{
    [TestClass()]
    public class GradingStudentsTests
    {
        [TestMethod()]
        public void TestCase0()
        {
            int[] array = new int[] { 73, 67, 38, 33 };
            int[] expected = new int[] { 75, 67, 40, 33 };
            int[] result = GradingStudents.gradingStudents(array);

            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void TestCase11()
        {
            int[] array = new int[] { 64, 24, 68, 14, 53, 49, 45, 99, 55, 24, 59, 67, 8, 76, 37, 24, 24, 73, 81, 37, 47, 63, 99, 63, 40, 54, 82, 9, 80, 84, 15, 32, 51, 18, 70, 4, 86, 59, 32, 68, 22, 1, 71, 51, 81, 22, 35, 65, 9, 17, 94, 69, 40, 39, 52, 94, 84, 13, 68, 95 };
            int[] expected = new int[] { 65, 24, 70, 14, 55, 50, 45, 100, 55, 24, 60, 67, 8, 76, 37, 24, 24, 75, 81, 37, 47, 65, 100, 65, 40, 55, 82, 9, 80, 85, 15, 32, 51, 18, 70, 4, 86, 60, 32, 70, 22, 1, 71, 51, 81, 22, 35, 65, 9, 17, 95, 70, 40, 40, 52, 95, 85, 13, 70, 95 };
            int[] result = GradingStudents.gradingStudents(array);

            CollectionAssert.AreEqual(expected, result);
        }
    }
}