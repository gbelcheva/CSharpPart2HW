namespace Methods
{
    using System;

    /// <summary>
    /// Constructor for the Student class.
    /// </summary>
    public class Student
    {
        public Student(string firstName, string lastName, DateTime birthDate, string otherInfo = "")
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.BirthDate = birthDate;
            this.OtherInfo = otherInfo;
        }

        public string FirstName { get; private set; }

        public string LastName { get; private set; }

        public DateTime BirthDate { get; private set; }

        public string OtherInfo { get; set; }

        /// <summary>
        /// Checks if the student is older than another student.
        /// </summary>
        /// <param name="otherStudent">The student to compare age with.</param>
        /// <returns>Returns true if the student is older, false otherwise.</returns>
        public bool IsOlderThan(Student otherStudent)
        {
            return this.BirthDate < otherStudent.BirthDate;
        }
    }
}
