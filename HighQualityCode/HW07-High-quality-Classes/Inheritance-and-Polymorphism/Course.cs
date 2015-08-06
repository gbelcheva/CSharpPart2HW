namespace InheritanceAndPolymorphism
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Abstraction;

    public class Course
    {
        private string name;
        private string teacherName;
        private ICollection<string> students;

        public Course(string name)
        {
            this.Name = name;
        }

        public Course(string name, string teacherName)
            : this(name)
        {
            this.TeacherName = teacherName;
        }

        public Course(string name, string teacherName, ICollection<string> students)
            : this(name, teacherName)
        {
            this.Students = students;
        }

        public string Name 
        {
            get
            {
                return this.name;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(string.Format(Messages.MustNotBeNullEmptyWhiteSpace, "Course name"));
                }

                this.name = value;
            }
        }

        public string TeacherName
        {
            get
            {
                return this.teacherName;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(string.Format(Messages.MustNotBeNullEmptyWhiteSpace, "Teacher name"));
                }

                this.teacherName = value;
            }
        }

        public ICollection<string> Students
        {
            get
            {
                return this.students;
            }

            set
            {
                this.students = value;
            }
        }

        public string GetStudentsAsString()
        {
            if (this.Students == null || this.Students.Count() == 0)
            {
                return "{ }";
            }
            else
            {
                return "{ " + string.Join(", ", this.Students) + " }";
            }
        }

        public void Add(params string[] students)
        {
            foreach (var student in students)
            {
                if (!string.IsNullOrWhiteSpace(student)) 
                {
                    this.Students.Add(student);
                }
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("LocalCourse { Name = ");
            result.Append(this.Name);

            if (this.TeacherName != null)
            {
                result.Append("; Teacher = ");
                result.Append(this.TeacherName);
            }

            result.Append("; Students = ");
            result.Append(this.GetStudentsAsString());
            result.Append(" }");

            return result.ToString();
        }
    }
}
