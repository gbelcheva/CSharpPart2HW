namespace _03.LargeLoremIpsum
{
    using Triepocalypse;

    public class Startup
    {
        public static void Main()
        {
            var trie = new Trie<int>();

            var text = new LargeText();
            text.ReadTextFromFile();
            text.ReadWordsFromFile();

            foreach (var word in text.WordsToSearch)
            {
                if (!trie.ContainsKey(word))
                {
                    trie.Add(word, 1);
                }

                if (text.Text.Contains(word))
                {
                    trie[word] += 1;
                }
            }

        }
    }
}
