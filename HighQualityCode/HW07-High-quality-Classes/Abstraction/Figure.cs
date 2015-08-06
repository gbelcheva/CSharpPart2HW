namespace Abstraction
{
    using System.Text;

    public abstract class Figure : IFigure
    {
        protected Figure()
        {
        }

        public abstract double GetPerimeter();

        public abstract double GetSurface();

        public override string ToString()
        {
            string name = this.GetType().Name;
            double perimeter = this.GetPerimeter();
            double surface = this.GetSurface();
            string article = this.CheckIfStartsWithVowel(name) ? "an" : "a";

            StringBuilder result = new StringBuilder();
            result.AppendFormat(
                "I am {0} {1}. My perimeter is {2:f2}. My surface is {3:f2}.", 
                article, 
                name.ToLower(),
                perimeter,
                surface);

            return result.ToString();
        }

        private bool CheckIfStartsWithVowel(string word)
        {
            return word.ToLower()[0] == 'a' ||
                   word.ToLower()[0] == 'e' ||
                   word.ToLower()[0] == 'i' ||
                   word.ToLower()[0] == 'o' ||
                   word.ToLower()[0] == 'u';
        }
    }
}
