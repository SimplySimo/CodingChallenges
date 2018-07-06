using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeChallenges.Algorithms___HackerRank.com.WarmUp.Easy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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