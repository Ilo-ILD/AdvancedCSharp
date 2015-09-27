namespace Problem1ReverseString
{
    using System;
    using System.Text;

    internal class Program
    {
        private static string ReverseString(string s)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = s.Length - 1; i >= 0; i--)
            {
                sb.Append(s[i]);
            }

            return sb.ToString();
        }
        private static void Main()
        {
            string s = Console.ReadLine();
            Console.WriteLine(ReverseString(s));
        }
    }
}