namespace Problem2StringLength
{
    using System;
    using System.Text;

    internal class Problem2StringLength
    {
        private static string ToStringBuilderAndAddingEmptySpaces(string s)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < 20; i++)
            {
                if (i >= s.Length)
                {
                    sb.Append('*');
                }
                else
                {
                    sb.Append(s[i]);
                }
            }

            return sb.ToString();
        }

        private static void Main()
        {
            string s = Console.ReadLine();
            Console.WriteLine(ToStringBuilderAndAddingEmptySpaces(s));
        }
    }
}