namespace CommonTypeSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Student : ICloneable, IComparable<Student>
    {
        private const int maxCourse = 5;
        private string phoneNumber;
        private string email;
        private int course;
        public enum Specialties { Physics, Astrophysics, Mathematics, AppliedMathematics, Biology, MolecularBiology}
        public enum Faculties { Physics, Mathematics, Biology}
        public enum Universities { SofiaUniversity, UniversityOfHeidelberg, SouthWesternUniversity, UniversityOfMunich}
        public Specialties Specialty { get; private set; }
        public Faculties Faculty { get; private set; }
        public Universities University { get; private set; }
        public string FirstName { get; private set;}
        public string MiddleName { get; private set; }
        public string LastName { get; private set; }
        public int SSN { get; private set; }
        public string PermanentAddress { get; private set; }
        public string PhoneNumber {
            get 
            { 
                return this.phoneNumber; 
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
                this.phoneNumber = value;
            }
        }
        public string EMail 
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
        public int Course 
        {
            get
            {
                return this.course;
            }
            private set 
            {
                if (value < 1 || maxCourse < value)
                {
                    throw new ArgumentOutOfRangeException("Valid course range is [1," + maxCourse + "]");
                }
                this.course = value;
            } 
        }
        public Student(string firstName, string middleName, string lastName, int SSNumber, int course, Specialties specialty, Faculties faculty, Universities university)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.SSN = SSNumber;
            this.Course = course;
            this.Specialty = specialty;
            this.Faculty = faculty;
            this.University = university;
        }
        public Student(string firstName, string middleName, string lastName, int SSNumber, int course, Specialties specialty, Faculties faculty, Universities university, string address, string phoneNumber, string eMail)
            : this(firstName, middleName, lastName, SSNumber, course, specialty, faculty, university)
        {
            this.PermanentAddress = address;
            this.PhoneNumber = phoneNumber;
            this.EMail = eMail;
        }
        public override bool Equals(object obj)
        {
            return (this.ToString() == (obj as Student).ToString());
        }
        public static bool operator ==(Student s1, Student s2)
        {
            return s1.Equals(s2);
        }
        public static bool operator !=(Student s1, Student s2)
        {
            return !(s1 == s2);
        }
        public override int GetHashCode()
        {
            int nameInt = this.FirstName.ToLower().ToCharArray()
                .Select(l => (int)l).Sum();
            nameInt += this.MiddleName.ToLower().ToCharArray()
                .Select(l => (int)l).Sum();
            nameInt += this.LastName.ToLower().ToCharArray()
                .Select(l => (int)l).Sum();
            return this.SSN << 3 ^ nameInt << 12;
        }
        public override string ToString()
        {
            return string.Format("{0} {1}, course {2}, {3}, Faculty of {4}, {5}", this.FirstName, this.LastName, this.Course, this.Specialty, this.Faculty, this.University);
        }

        public Student Clone()
        {
            if (this.PermanentAddress != null && this.phoneNumber != null && this.EMail != null)
            {
                return new Student(this.FirstName, this.MiddleName, this.LastName, this.SSN, this.Course, this.Specialty, this.Faculty, this.University, this.PermanentAddress, this.PhoneNumber, this.EMail);
            }
            return new Student(this.FirstName, this.MiddleName, this.LastName, this.SSN, this.Course, this.Specialty, this.Faculty, this.University);
        }
        object ICloneable.Clone()
        {
            return this.Clone();
        }

        public int CompareTo(Student other)
        {
            string fullNameThis = string.Format("{0}{1}{2}", this.FirstName, this.MiddleName, this.LastName).ToLower();
            string fullNameOther = string.Format("{0}{1}{2}", other.FirstName, other.MiddleName,other.LastName).ToLower();

            if (fullNameThis != fullNameOther)
            {
                return fullNameThis.CompareTo(fullNameOther);
            }
            else
            {
                return this.SSN.CompareTo(other.SSN);
            }
        }

        
    }
}
