using System;
using CodeChallenges.RandomChallengs;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeChallengesTests.RandomChallengs
{
    [TestClass()]
    public class DecimalToFractionsTests
    {
        [TestMethod()]
        public void WholeNumberTest()
        {
            decimal valueToTest = 4;
            string expected = "4";
            string result = DecimalToFractions.Fractional(Convert.ToDecimal(valueToTest));

            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void ZeroTest()
        {
            decimal valueToTest = 0;
            string expected = "0";
            string result = DecimalToFractions.Fractional(Convert.ToDecimal(valueToTest));

            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void LongDecimalTest()
        {
            decimal valueToTest = 4.50M;
            string expected = "4 2/4";
            string result = DecimalToFractions.Fractional(Convert.ToDecimal(valueToTest));

            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void ShortDecimalTest()
        {
            decimal valueToTest = 4.5M;
            string expected = "4 2/4";
            string result = DecimalToFractions.Fractional(Convert.ToDecimal(valueToTest));

            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void RandomDecimalTest()
        {
            decimal valueToTest = 4.78M;
            string expected = "4 3/4";
            string result = DecimalToFractions.Fractional(Convert.ToDecimal(valueToTest));

            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void RoundToNextNumber()
        {
            decimal valueToTest = 4.99M;
            string expected = "5";
            string result = DecimalToFractions.Fractional(Convert.ToDecimal(valueToTest));

            Assert.AreEqual(expected, result);
        }
    }
}