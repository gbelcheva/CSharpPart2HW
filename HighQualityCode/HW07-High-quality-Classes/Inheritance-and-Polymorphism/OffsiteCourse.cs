﻿namespace InheritanceAndPolymorphism
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Abstraction;

    public class OffsiteCourse : Course
    {
        private string town;

        public OffsiteCourse(string courseName)
            : base(courseName)
        {
        }

        public OffsiteCourse(string courseName, string teacherName)
            : base(courseName, teacherName)
        {
        }

        public OffsiteCourse(string courseName, string teacherName, IList<string> students)
            : base(courseName, teacherName, students)
        {
        }

        public OffsiteCourse(string courseName, string teacherName, IList<string> students, string town)
            : base(courseName, teacherName, students)
        {
            this.Town = town;
        }

        public string Town 
        {
            get
            {
                return this.town;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(string.Format(Messages.MustNotBeNullEmptyWhiteSpace, "Town name"));
                }

                this.town = value;
            }
        }

        public override string ToString()
        {
            string baseString = base.ToString();
            StringBuilder result = new StringBuilder(baseString.Substring(0, baseString.Length - 1));

            if (this.Town != null)
            {
                result.Append("; Town = ");
                result.Append(this.Town);
            }

            result.Append(" }");

            return result.ToString();
        }   
    }
}