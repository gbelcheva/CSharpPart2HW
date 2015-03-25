using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApp
{
    public class Student
    {
        private int age;
        private string email;
        private List<int> marks = new List<int>();
        private string tel;
        public Student(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }
        public Student(string firstName, string lastName, int age, string email, List<int> marks, int fN, string tel, int groupNumber)
            : this(firstName, lastName, age)
        {
            this.Email = email;
            this.Marks = marks;
            this.FN = fN;
            this.Tel = tel;
            this.GroupNumber = groupNumber;

        }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int GroupNumber { get; private set; }
        public int FN { get; private set; }

        public int Age 
        {
            get 
            {
                return this.age;
            }
            private set 
            {
                if (0 > value || value > 120)
                {
                    throw new ArgumentException("Invalid age");
                }
                this.age = value;
            }
        }
        public List<int> Marks
        {
            get
            {
                return this.marks;
            }
            private set
            {
                foreach (var mark in value)
                {
                    if (mark < 2 || 6 < mark)
                    {
                        throw new ArgumentException("Invalid mark");
                    }
                }
                this.marks = value;
            }
        }

        public string Email
        {
            get
            {
                return this.email;
            }
            private set
            {
                int count = 0;
                foreach (var ch in value)
                {
                    if (ch == '@')
                    {
                        count++;
                    }
                    if (count > 1)
                    {
                        throw new ArgumentException("Invalid email");
                    }
                }
                this.email = value;
            }
        }
        public string Tel
        {
            get
            {
                return this.tel;
            }
            private set
            {
                foreach (var ch in value)
                {
                    if (!char.IsDigit(ch) && ch != '+')
                    {
                        throw new ArgumentException("Invalid telephone");
                    }
                }
                this.tel = value;
            }
        }
        

        public override string ToString()
        {
            return this.FirstName + " " + this.LastName + ", " + this.Age;
        }
        public string ToStringExt()
        {
            return this.ToString() + ", " + this.FN + ", " + this.Tel + ", " + this.Email + ", [" + string.Join(", ", this.Marks) + "], " + this.GroupNumber;
        }
    }
}
