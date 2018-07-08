using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeChallenges.com.Strings.Easy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenges.Algorithms___HackerRank.com.Strings.Easy.Tests
{
    [TestClass()]
    public class StrongPasswordTests
    {
        [TestMethod()]
        public void Testcase0()
        {
            int n = 3;
            string input = "Ab1";
            int expected = 3;
            int result = StrongPassword.minimumNumber(n, input);

            Assert.AreEqual(expected,result);
        }

        [TestMethod()]
        public void Testcase1()
        {
            int n = 11;
            string input = "#HackerRank";
            int expected = 1;
            int result = StrongPassword.minimumNumber(n, input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void Testcase27()
        {
            int n = 4;
            string input = "4700";
            int expected = 3;
            int result = StrongPassword.minimumNumber(n, input);

            Assert.AreEqual(expected, result);
        }
    }
}