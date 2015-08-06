namespace Task2_Compare_simple_Maths
{
    using System;
    using System.Diagnostics;

    public class PerformanceComparer
    {
        private const int IntValue = 1;
        private const long LongValue = 1L;
        private const float FloatValue = 1.0F;
        private const double DoubleValue = 1.0;
        private const decimal DecimalValue = 1M;
        private static readonly Stopwatch stopwatch = new Stopwatch();
        public const int IterationsCount = 10000000;

        public TimeSpan TimeExecution(Operations operation, Values value) 
        {
            dynamic  val;
            TimeSpan executionTime;

            if (value == Values.intValue)
            {
                val = IntValue;
            }
            else if (value == Values.longValue)
            {
                val = LongValue;
            }
            else if (value == Values.floatValue)
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

            stopwatch.Start();

            var result = val;
            switch (operation)
            {
                case Operations.add:
                    for (int i = 0; i < IterationsCount; i++)
                    {
                        result = val + val;
                    }
                    break;
                case Operations.subtract:
                    for (int i = 0; i < IterationsCount; i++)
                    {
                        result = val - val;
                    }
                    break;
                case Operations.increment:
                    for (int i = 0; i < IterationsCount; i++)
                    {
                        val++;
                    }
                    break;
                case Operations.multiply:
                    for (int i = 0; i < IterationsCount; i++)
                    {
                        result = val * val;
                    }
                    break;
                case Operations.divide:
                    for (int i = 0; i < IterationsCount; i++)
                    {
                        result = val / val;
                    }
                    break;
                default: throw new InvalidOperationException("The passed operation " + operation + " is not valid.");
            }

            stopwatch.Stop();

            executionTime = stopwatch.Elapsed;

            return executionTime;
        }
    }
}
