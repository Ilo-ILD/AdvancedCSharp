namespace Problem1SeriesLetters
{
    using System;
    using System.Linq;

    internal class Problem1SeriesLetters
    {
        private static string MatchRegexSingleChar(string name)
        {
            name =
                new string(
                    name.Select((x, i) => new { x, i })
                        .Where(x => x.i == name.Length - 1 || name[x.i + 1] != x.x)
                        .Select(x => x.x)
                        .ToArray());
            return name;
        }

        private static void Main()
        {
            string s = Console.ReadLine();
            Console.WriteLine(MatchRegexSingleChar(s));
        }
    }
}