using CodeChallenges.com.Strings.Easy;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeChallenges.Algorithms___HackerRank.com.Strings.Easy.Tests
{
    [TestClass()]
    public class CamelCaseTests
    {
        [TestMethod()]
        public void Testcase0()
        {
            string input = "saveChangesInTheEditor";
            int expected = 5;
            int result = CamelCase.camelcase(input);

            Assert.AreEqual(expected, result);
        }
    }
}