using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeChallenges.Algorithms___HackerRank.com.Implementation.Medium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenges.Algorithms___HackerRank.com.Implementation.Medium.Tests
{
    [TestClass()]
    public class EncryptionTests
    {
        [TestMethod()]
        public void Testcase0()
        {
            string input = "haveaniceday";
            string expected = "hae and via ecy";
            string result = Encryption.encryption(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void Testcase1()
        {
            string input = "feedthedog";
            string expected = "fto ehg ee dd";
            string result = Encryption.encryption(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void Testcase2()
        {
            string input = "chillout";
            string expected = "clu hlt io";
            string result = Encryption.encryption(input);

            Assert.AreEqual(expected, result);
        }
    }
}