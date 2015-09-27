namespace Problem6CountSymbols
{
    using System;
    using System.Collections.Generic;

    internal class Problem6CountSymbols
    {
        private static void Main()
        {
            string readLine = Console.ReadLine();
            SortedDictionary<char, int> countsOfChars = new SortedDictionary<char, int>();
            int count = 1;

            for (int i = 0; i < readLine.Length; i++)
            {
                if (countsOfChars.ContainsKey(readLine[i]))
                {
                    int value = countsOfChars[readLine[i]];
                    countsOfChars.Remove(readLine[i]);
                    countsOfChars.Add(readLine[i], count + value);
                }
                else
                {
                    countsOfChars.Add(readLine[i], count);
                }
            }

            foreach (KeyValuePair<char, int> p in countsOfChars)
            {
                Console.WriteLine("{0}: {1} time/s", p.Key, p.Value);
            }
        }
    }
}