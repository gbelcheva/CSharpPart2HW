namespace MainApp
{
    using System;
    public class Student : Person, ICommentable
    {
        private string comment;
        public int ClassNumber { get; private set; }

        public string Comment
        {
            get
            {
                if (string.IsNullOrEmpty(this.comment))
                {
                    return "no comments";
                }
                return this.comment;
            }
            set
            {
                this.comment = value;
            }
        }
        public Student(string name, int classNumber, string comment)
            : base(name)
        {
            this.ClassNumber = classNumber;
            this.Comment = comment;
        }
    }
}
