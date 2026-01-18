namespace dbCalc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            double db1 = 56;
            double db2 = 40;
            double sum = DecibelCalculator.dbSum(db1, db2);
            double diff = DecibelCalculator.dbDiff(db1, db2);
            double ratio = DecibelCalculator.dbRatio(db1, db2);

            Console.WriteLine("Noise Level Calculator");
            Console.WriteLine("Sum of, db: (" + db1 + ", " + db2 + ") = " + sum.ToString("F1"));
            Console.WriteLine("Diff of, db: (" + db1 + ", " + db2 + ") = " + diff.ToString("F1"));
            Console.WriteLine("Ratio of, db: (" + db1 + ", " + db2 + ") = " + ratio.ToString("F1"));
            Console.WriteLine("-----------------------------------------");
        }
    }
}
