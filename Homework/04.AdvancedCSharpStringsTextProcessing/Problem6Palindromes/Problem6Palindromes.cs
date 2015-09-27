namespace Problem6Palindromes
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    internal class Problem6Palindromes
    {
        //private static int HowManyCommas(string name)
        //{
        //    int count = 0;
        //    for (int i = 0; i < name.Length; i++)
        //    {
        //        if ((i >= 32 && i <= 48) && (i >= 58 && i <= 64))
        //        {
        //            count++;
        //        }
        //    }
        //    return count;
        //}
        private static string ReverseString(string s)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = s.Length - 1; i >= 0; i--)
            {
                sb.Append(s[i]);
            }

            return sb.ToString();
        }

        private static List<string> Palindromes(string name)
        {
            string[] words = name.Split(new[] { ' ', '.', '!', '?', ',' }, StringSplitOptions.RemoveEmptyEntries);

            List<string> sbnew = new List<string>();

            for (int i = 0; i < words.Length; i++)
            {
                string reversWord = ReverseString(words[i]);
                if (words[i] == reversWord)
                {
                    sbnew.Add(words[i]);
                }
            }

            sbnew.Sort();
            return sbnew;
        }

        private static void Main()
        {
            string s = Console.ReadLine();
            Console.WriteLine("{0,10}", string.Join(", ", Palindromes(s)));
        }
    }
}