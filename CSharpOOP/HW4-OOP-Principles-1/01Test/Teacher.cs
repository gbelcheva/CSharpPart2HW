namespace MainApp
{
    using System;
    using System.Collections.Generic;
    public class Teacher : Person, ICommentable
    {
        private string comment;
        public List<Discipline> Disciplines { get; private set; }

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
        public Teacher(string name, List<Discipline> disciplines, string comment) : base(name)
        {
            this.Disciplines = disciplines;
            this.Comment = comment;
        }
    }
}
