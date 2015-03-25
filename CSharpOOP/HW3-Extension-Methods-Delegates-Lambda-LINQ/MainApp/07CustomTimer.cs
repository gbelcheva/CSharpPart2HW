namespace MainApp
{
    using System;
    using System.Threading;

    public class CustomTimer
    {
        private int interval;
        private int iterations;
        public delegate void TimedExecution();
        public CustomTimer(int interval, int iterations, TimedExecution timedExe)
        {
            this.Intervalms = interval;
            this.Iterations = iterations;
            this.TimedExe = timedExe;
        }
        public TimedExecution TimedExe { get; private set; }
        public int Intervalms
        {
            get
            {
                return this.interval;
            }
            set 
            {
                if (value < 1)
                {
                    throw new ArgumentException("Interval cannot be less than 1 s");
                }
                this.interval = value * 1000;
            }
        }
        public int Iterations
        {
            get
            {
                return this.iterations;
            }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Iterations cannot be less than 1");
                }
                this.iterations = value;
            }
        }

        public void ExecuteTimed()
        {
            for (int i = 0; i < this.Iterations; i++)
            {
                Thread.Sleep(this.Intervalms);
                this.TimedExe();
            }
            Thread.Sleep(this.Intervalms);
        }
    }
}
