namespace Problem3ExtractEmails
{
    using System;
    using System.Text.RegularExpressions;

    internal class Problem3ExtractEmails
    {
        private static void MatchRegexEmail(string name)
        {
            Regex aTagRegex = new Regex(@"(\w[-._\w]*\w@\w[-._\w]*\w\.[A-Za-z]{2,3})");
            Match m = aTagRegex.Match(name);
            Console.WriteLine(m.Value);
            if (m.NextMatch() != Match.Empty)
            {
                Console.WriteLine(m.NextMatch());
            }
        }
        private static void Main()
        {
            string s = Console.ReadLine();
            MatchRegexEmail(s);
        }
    }
}