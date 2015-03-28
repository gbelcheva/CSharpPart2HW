namespace TestProgram
{
    using System;

    public class Worker : Human
    {
        private decimal weekSalary;
        private int workHoursPerDay;
        public decimal WeekSalary 
        {
            get
            {
                return this.weekSalary;
            }
            private set 
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Week salary should be greater than 0");
                }
                this.weekSalary = value;
            } 
        }
        public int WorkHoursPerDay
        {
            get
            {
                return this.workHoursPerDay;
            }
            private set
            {
                if (value < 0 || 24 < value)
                {
                    throw new ArgumentOutOfRangeException("Work hours per day should be in the interval [0,24]");
                }
                this.workHoursPerDay = value;
            }
        }
        public Worker(string firstName, string lastName, decimal weekSalary, int workHoursPerDay)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public decimal MoneyPerHour()
        {
            return this.WeekSalary / (5 * this.WorkHoursPerDay);
        }

        public override string ToString()
        {
            return base.ToString() + ", " + this.MoneyPerHour().ToString("C2", System.Globalization.CultureInfo.GetCultureInfo("en-US"));
        }
    }
}
