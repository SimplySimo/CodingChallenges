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
    public class MiniMaxSumTests
    {
        [TestMethod()]
        public void TestCase0()
        {
            int[] array1 = { 1, 2, 3, 4, 5 };
            long[] expected = { 10, 14 };
            long[] result = MiniMaxSum.miniMaxSum(array1);

            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void TestCase1()
        {
            int[] array1 = { 256741038, 623958417, 467905213, 714532089, 938071625 };
            long[] expected = { 2063136757, 2744467344 };
            long[] result = MiniMaxSum.miniMaxSum(array1);

            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void TestCase2()
        {
            int[] array1 = { 396285104, 573261094, 759641832, 819230764, 364801279 };
            long[] expected = { 2093989309, 2548418794 };
            long[] result = MiniMaxSum.miniMaxSum(array1);

            CollectionAssert.AreEqual(expected, result);
        }
    }
}