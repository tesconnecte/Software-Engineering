using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Statistics.Lib;

namespace Staticstics.Test
{
    [TestClass]
    public class CalculateTest
    {
        [TestMethod]
        public void SummationTest()
        {
            double[] t = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            double expectedResult = 211;
            double actualResult = Calculate.Summation(t);

            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void MeanTest()
        {
            double[] t = { 2,4,6,8,10,12 };
            double expectedResult = 7;
            double actualResult = Calculate.Mean(t);

            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void RandomNumberTest()
        {
            int min =  50 ;
            int max = 100;
            int expectedResult = 57;
            int actualResult = Calculate.RandomNumber(min,max);

            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void VarianceTest()
        {
            double[] t = { 17,32,34,65,67,99,102 };
            double delta = 0.01;
            double expectedResult = 1110.95;
            double actualResult = Calculate.Variance(t);

            Assert.AreEqual(expectedResult, actualResult,delta);

        }

        [TestMethod]
        public void StandardDeviationTest()
        {
            double[] t = { 4, 12, 14, 21, 22, 25, 27, 28, 34, 42, 58, 67 };
            double delta = 0.00001;
            double expectedResult = 18.46126;
            double actualResult = Calculate.StandardDeviation(t);

            Assert.AreEqual(expectedResult, actualResult, delta);

        }

        [TestMethod]
        public void NormalDistributionTest()
        {
            double[] t = { 2,4,6,8,10,12,14,16,18,20 };
            double x = 10;
            double delta = 0.00001;
            double expectedResult = 0.06499085;
            double actualResult = Calculate.NormalDistribution(t,x);

            Assert.AreEqual(expectedResult, actualResult, delta);

        }
    }
}
