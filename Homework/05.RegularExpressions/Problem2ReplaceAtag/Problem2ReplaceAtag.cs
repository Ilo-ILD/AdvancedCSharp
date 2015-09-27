namespace Problem2ReplaceAtag
{
    using System;
    using System.Text.RegularExpressions;

    internal class Problem2ReplaceAtag
    {
        private static string MatchRegexTag(string name)
        {
            string pattern = @"<a.+?\s*href\s*=\s*[""\\'']?([^""\''\s>]+)[""\'']*>[A-Za-z]+<.a>";
            string replaceString = "[URL href=http://softuni.bg]SoftUni[/URL]";
            Regex aTagRegex = new Regex(pattern); 

            string output = aTagRegex.Replace(name, replaceString);
            return output;
        }

        private static void Main()
        {
            string s = Console.ReadLine();
            Console.WriteLine(MatchRegexTag(s));
        }
    }   //"<ul> <li> <a href="http://softuni.bg">SoftUni</a> </li> </ul>"
        //"<ul> <li> <a href='http://softuni.bg'>SoftUni</a> </li> </ul>"
}