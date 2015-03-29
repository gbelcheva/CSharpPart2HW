using System;

namespace CommonTypeSystem
{
    class Person
    {
        private const int maxAge = 120;
        private int? age;
        public string Name { get; private set; }
        public int? Age 
        {
            get 
            {
                return this.age;
            }
            private set 
            {
                if (value < 0 || maxAge < value)
                {
                    throw new ArgumentOutOfRangeException("Age can only be in the range [0," + maxAge + "]");
                }
                this.age = value;
            }
        }
        public Person(string name, int? age)
        {
            this.Name = name;
            this.Age = age;
        }

        public override string ToString()
        {
            return string.Format("{0}, {1}", this.Name, this.Age != null ? this.Age.ToString() : "unspecified age");
        }
    }
}
