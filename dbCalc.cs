
namespace dbCalc
{
    public static class DecibelCalculator
    {
        /// <summary>
        /// Sum of two sound levels in decibel
        /// </summary>
        /// <param name="db1">double</param>
        /// <param name="db2">double</param>
        /// <returns>double</returns>
        public static double dbSum(double db1, double db2)
        {
            try
            {
                double db2Decimal = Math.Pow(10.0, db1 / 10.0) + Math.Pow(10.0, db2 / 10.0);
                return 10.0 * Math.Log10(db2Decimal);
            }
            catch { throw; }
        }

        /// <summary>
        /// Diff of two sound levels in decibel
        /// </summary>
        /// <param name="db1">double</param>
        /// <param name="db2">double</param>
        /// <returns>double</returns>
        public static double dbDiff(double db1, double db2)
        {
            try
            {
                double db2Decimal = Math.Pow(10.0, db1 / 10.0) - Math.Pow(10.0, db2 / 10.0);
                return 10.0 * Math.Log10(db2Decimal);
            }
            catch { throw; }
        }

        /// <summary>
        /// Decibel sound levels ratio
        /// </summary>
        /// <param name="db1">double</param>
        /// <param name="db2">double</param>
        /// <returns>double</returns>
        public static double dbRatio(double db1, double db2)
        {
            try
            {
                double dec1 = Math.Pow(10.0, db1 / 10.0);
                double dec2 = Math.Pow(10.0, db2 / 10.0);
                return dec1 / dec2; ;
            }
            catch { throw; }
        }
    }
}
