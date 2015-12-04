namespace _03.LargeLoremIpsum
{
    using System;
    using System.IO;

    public class LargeText
    {
        public string Text { get; set; }

        public string[] WordsToSearch { get; set; }

        public void ReadTextFromFile()
        {
            string path = @"../../LargeLoremIpsum.txt";

            this.Text = File.ReadAllText(path);
        }

        public void ReadWordsFromFile()
        {

            this.WordsToSearch = new string[0];
            string path = @"../../Words.txt";

            var lines = File.ReadAllLines(path);

            foreach (var line in lines)
            {
                string[] words = line.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                int wordsArrayLength = words.Length;
                Array.Resize<string>(ref words, wordsArrayLength + this.WordsToSearch.Length);
                Array.Copy(this.WordsToSearch, 0, words, wordsArrayLength, this.WordsToSearch.Length);
            }
        }
    }
}
