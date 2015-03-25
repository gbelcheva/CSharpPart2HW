namespace MainApp
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;

    public class CustomEventArgs : EventArgs
    {
        public CustomEventArgs(string s)
        {
            message = s;
        }
        private string message;

        public string Message
        {
            get { return message; }
            set { message = value; }
        }
    }
    public delegate void TimedExecution();
    class CustomTimerEventPublisher
    {
        private int iterations;
        public TimedExecution TimedExe { get; private set; }
        // Declare the event using EventHandler<T> 
        public event EventHandler<CustomEventArgs> RaiseCustomEvent;
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

        public void ExecuteMethods(int iterations, TimedExecution timedExe)
        {
            for (int i = 0; i < iterations; i++)
            {
                timedExe();
                OnRaiseCustomEvent(new CustomEventArgs("Did something"));
            }

        }

        // Wrap event invocations inside a protected virtual method 
        // to allow derived classes to override the event invocation behavior 
        protected virtual void OnRaiseCustomEvent(CustomEventArgs e)
        {

            EventHandler<CustomEventArgs> handler = RaiseCustomEvent;

            // Event will be null if there are no subscribers 
            if (handler != null)
            {
                // Format the string to send inside the CustomEventArgs parameter
                e.Message += String.Format(" at {0}", DateTime.Now.ToString());

                // Use the () operator to raise the event.
                handler(this, e);
            }
        }
    }
    
    class CustomTimerEventSubscriber
    {
        private int interval;
        
        // Define what actions to take when the event is raised. 
        
        public CustomTimerEventSubscriber(int interval, CustomTimerEventPublisher pub)
        {
            this.Intervalms = interval;
            pub.RaiseCustomEvent += HandleCustomEvent;
        }
        
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
        void HandleCustomEvent(object sender, CustomEventArgs e)
        {
            Thread.Sleep(this.Intervalms);
        }
    }
}
