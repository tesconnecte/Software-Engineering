using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statistics.Lib
{
    /// <summary>
    /// This class is used to perform some mathematical calculations.
    /// </summary>
    public static class Calculate
    {
        /// <summary>
        /// Summation (total) of double array.
        /// </summary>		
        public static double Summation(double[] t)
        {
            return t.Sum();
        }

        /// <summary>
        /// Calculates the mean value of double array.
        /// </summary>
        public static double Mean(double[] t)
        {
            // Mean = (∑X/N)
            return (t.Sum() / t.Count());
        }

        /// <summary>
        /// Calculates a random number within the defined min and max range.
        /// </summary>
        public static int RandomNumber(int min, int max)
        {
            Random r = new Random(1111); //Note that the seed is hardcoded for testing purposes so we always get the same result!

            int randNumber = r.Next(min, max);
            return randNumber;
        }

        /// <summary>
        /// Calculates the variance of double array.
        /// </summary>
        public static double Variance(double[] t)
        {
            // Variance = (∑(X-M)^2 / n - 1)
            return (t.Sum(d => Math.Pow(d - Mean(t), 2))) / (t.Count() - 1);
        }

        /// <summary>
        /// Calculates the standard deviation of double array.
        /// </summary>
        public static double StandardDeviation(double[] t)
        {
            // StandardDeviation = √(∑(X-M)^2 / n - 1)   
            return Math.Sqrt(Variance(t));
        }

        /// <summary>
        /// Calculates the normal distribution of input x.
        /// </summary>	
        public static double NormalDistribution(double[] t, double x)
        {
            //See Wikipedia for Formula: http://tinyurl.com/cyakwem
            return (1 / (StandardDeviation(t) * Math.Sqrt(2 * Math.PI))) * Math.Exp((-(Math.Pow(x - Mean(t), 2) / (2 * Math.Pow(StandardDeviation(t), 2)))));
        }
    }
}
