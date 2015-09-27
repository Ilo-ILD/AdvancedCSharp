namespace Problem3CountSubstringOccurrences
{
    using System;

    internal class Problem3CountSubstringOccurrences
    {
        private static int HowManyTimesIsReapiting(string consola, string key)
        {
            int countReapiting = 0;
            int countForKey = 0;

            for (int i = 0; i < consola.Length; i++)
            {
                int index = consola.IndexOf(key, countForKey);
                if (i != index)
                {
                    continue;
                }

                countReapiting++;
                countForKey = index + 1;
            }

            return countReapiting != 0 ? countReapiting : 0;
        }

        private static void Main()
        {
            string readingLine = Console.ReadLine().ToLower();
            string wordOrSimbolForSearch = Console.ReadLine();
            Console.WriteLine(HowManyTimesIsReapiting(readingLine, wordOrSimbolForSearch));
        }
    }
}