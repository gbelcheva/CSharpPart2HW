
namespace Phone
{
    using System;
    class Call
    {
        private DateTime time;
        private string dialedNumber;
        private TimeSpan duration;

        public Call(DateTime callTime, string callDialedNumber, TimeSpan callDuration)
        {
            this.Time = callTime;
            this.DialedNumber = callDialedNumber;
            this.Duration = callDuration;
        }

        public DateTime Time
        {
            get
            {
                return this.time;
            }
            set
            {
                this.time = value;
            }
        }
        public string DialedNumber
        {
            get
            {
                return this.dialedNumber;
            }
            private set
            {
                foreach (var sym in value)
                {
                    if (sym != '+' && !Char.IsDigit(sym))
                    {
                        throw new ArgumentException("Not a valid number");
                    }
                }
                this.dialedNumber = value;

            }
        }
        public TimeSpan Duration
        {
            get
            {
                return this.duration;
            }
            private set
            {
                this.duration = value;
                    
            }
        }

        public override string ToString()
        {
            string CallInfo = this.Time + " " + this.DialedNumber + " " + this.Duration.TotalSeconds + "s";
            return CallInfo;
        }

    }
}