namespace Task3_Compare_advanced_Maths
{
    using System;
    using System.Diagnostics;

    public class PerformanceComparer
    {
        public const int IterationsCount = 10000000;
        private const float FloatValue = 1.0F;
        private const double DoubleValue = 1.0;
        private const decimal DecimalValue = 1M;
        private static readonly Stopwatch StopWatch = new Stopwatch();

        public TimeSpan TimeExecution(Operations operation, Values value) 
        {
            dynamic val;
            TimeSpan executionTime;

            if (value == Values.floatValue)
            {
                val = FloatValue;
            }
            else if (value == Values.doubleValue)
            {
                val = DoubleValue;
            }
            else
            {
                val = DecimalValue;
            }

            StopWatch.Start();

            double result;
            switch (operation)
            {
                case Operations.squareRoot:
                    for (int i = 0; i < IterationsCount; i++)
                    {
                        result = Math.Sqrt((double)val);
                    }

                    break;
                case Operations.naturalLogarithm:
                    for (int i = 0; i < IterationsCount; i++)
                    {
                        result = Math.Log((double)val);
                    }

                    break;
                case Operations.sinus:
                    for (int i = 0; i < IterationsCount; i++)
                    {
                        result = Math.Sin((double)val);
                    }

                    break;
                default: throw new InvalidOperationException("The passed operation " + operation + " is not valid.");
            }

            StopWatch.Stop();

            executionTime = StopWatch.Elapsed;

            return executionTime;
        }
    }
}
