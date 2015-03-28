namespace MainApp
{
    using System;
    using System.Collections.Generic;
    public class SchoolClass : ICommentable
    {
        private string comment;
        public List<Teacher> Teachers { get; private set; }

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
        public SchoolClass(List<Teacher> teachers, string comment)
        {
            this.Teachers = teachers;
            this.Comment = comment;
        }
    }
}
