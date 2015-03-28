namespace TestProgram
{
    using System;

    public class Student : Human
    {
        private int grade;
        public int Grade 
        {
            get 
            {
                return this.grade;
            }
            private set 
            {
                if (value < 2 || 6 < value)
                {
                    throw new ArgumentOutOfRangeException("Valid grades are in the interval [2,6]");
                }
                this.grade = value;
            }
        }
        public Student(string firstName, string lastName, int grade)
            : base(firstName, lastName)
        {
            this.Grade = grade;
        }
        public override string ToString()
        {
            return base.ToString() + ", " + this.Grade;
        }
    }
}
