namespace Problem4TextReplace
{
    using System;
    using System.Text.RegularExpressions;

    internal class Problem4TextReplace
    {
        private static string Texts = "";

        private static string SearchingForNextWord(string text)
        {
            string[] words = text.Split(',', ' ');
            string temp = "";
            string finalText = Texts;

            for (int i = 0; i < words.Length; i++)
            {
                if (i % 2 == 0)
                {
                    temp = MatchRegexTag(finalText, words[i]);
                }
                else
                {
                    finalText = MatchRegexTag(temp, words[i]);
                }
            }

            if (words.Length % 2 == 1)
            {
                return temp;
            }
            else
            {
                return finalText;
            }
        }

        private static string ReaplaceString(string text)
        {
            string reaplaceStrinf = "";
            for (int i = 0; i < text.Length; i++)
            {
                reaplaceStrinf += "*";
            }

            return reaplaceStrinf;
        }

        private static string MatchRegexTag(string name, string key)
        {
            string replaceString = ReaplaceString(key);
            Regex aTagRegex = new Regex(key);

            string output = aTagRegex.Replace(name, replaceString);
            return output;
        }

        private static void Main()
        {
            string word = Console.ReadLine();
            string text = Console.ReadLine();
            Texts = text;
            Console.WriteLine(SearchingForNextWord(word));
        }
    }
}