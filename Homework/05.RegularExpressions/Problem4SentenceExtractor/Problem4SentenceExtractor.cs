namespace Problem4SentenceExtractor
{
    using System;
    using System.Text.RegularExpressions;

    internal class Problem4SentenceExtractor
    {
        private static string Keyword;

        private static void SplittingTextToSentences(string text)
        {
            string[] sentences = text.Split('.', '!', '?');

            for (int i = 0; i < sentences.Length; i++)
            {
                if (IsThereAnyMatch(sentences[i], Keyword) != "")
                {
                    Console.WriteLine(sentences[i]);
                }
            }
        }

        private static string IsThereAnyMatch(string text, string key)
        {
            string newKey = "\\s" + key + "\\s";
            Regex regex = new Regex(newKey);
            Match m = regex.Match(text);
            if (m.Success)
            {
                return text;
            }

            string noMatch = "";
            return noMatch;
        }

        private static void Main()
        {
            string keyword = Console.ReadLine();
            string text = Console.ReadLine();
            Keyword = keyword;
            SplittingTextToSentences(text);
        }
    }
}