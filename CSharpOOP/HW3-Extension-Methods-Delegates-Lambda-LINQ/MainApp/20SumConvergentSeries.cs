namespace MainApp
{
    using System;

    
    public class SumConvergentSeries
    {
        private const double Precision = 0.001;
        public static double EvaluateSum(string expressionTerm)
        {
            int iteration = 0;
            double currentSum = 0;
            double previousSum = 0;
            do
            {
                previousSum = currentSum;
                string tmpExpression = expressionTerm.Replace("x", iteration.ToString());
                currentSum += EvaluateExpression.StartCalculating(tmpExpression);
                //Console.WriteLine(Math.Abs(previousSum - currentSum));
                iteration++;
                
            } while (Math.Abs(previousSum - currentSum) > Precision);
            return currentSum;
        }
    }
}
