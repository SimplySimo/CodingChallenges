using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace CodeChallenges.Algorithms___HackerRank.com.WarmUp.Easy.Tests
{
    [TestClass()]
    public class StaircaseTests
    {
        [TestMethod()]
        public void staircaseTest()
        {
            int stairs = 6;
            List<string> expected = new List<string>() { "     #", "    ##", "   ###", "  ####", " #####", "######"};
            List<string> result = Staircase.staircase(stairs);
            CollectionAssert.AreEqual(expected, result);
        }
    }
}