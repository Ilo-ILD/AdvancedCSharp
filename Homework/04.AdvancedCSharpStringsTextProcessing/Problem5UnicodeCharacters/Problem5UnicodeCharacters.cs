namespace Problem5UnicodeCharacters
{
    using System;
    using System.Text;

    internal class Problem5UnicodeCharacters
    {
        private static string StringToChar(string name)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in name)
            {
                sb.Append("\\u");
                sb.Append(string.Format("{0:x4}", (int)c));
            }

            return sb.ToString();
        }

        private static void Main()
        {
            string s = Console.ReadLine();

            Console.WriteLine(StringToChar(s));
        }
    }
}