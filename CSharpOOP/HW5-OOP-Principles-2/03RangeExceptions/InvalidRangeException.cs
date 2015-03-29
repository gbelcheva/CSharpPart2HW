namespace _03RangeExceptions
{
    using System;

    class InvalidRangeException<T> : ApplicationException
    {
        private const string exMessage = "{0}. Valid range is [{1} ... {2}]";
        public T Start { get; set; }
        public T End { get; set; }
        public InvalidRangeException(string msg, T start, T end)
            : base(string.Format(exMessage, msg, start, end))
        {
            this.Start = start;
            this.End = end;
        }
        public InvalidRangeException(string msg, T start, T end, Exception innerEx)
            : base(string.Format(exMessage, msg, start, end), innerEx)
        {
            this.Start = start;
            this.End = end;
        }
    }
}
