namespace MainApp
{
    using System;
    public class Discipline : ICommentable
    {
        private string comment;
        public string Name { get; private set; }

        public int NumberOfLectures { get; private set; }

        public int NumberOfExercises { get; private set; }

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
        public Discipline(string name, int numberOfLectures, int numberOfExercises, string comment)
        {
            this.Name = name;
            this.NumberOfLectures = numberOfLectures;
            this.NumberOfLectures = numberOfExercises;
            this.Comment = comment;
        }
    }
}
