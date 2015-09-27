namespace SortArrayWhitSelection
{
    using System;
    using System.Collections.Generic;

    internal class SortArrayWhitSelection
    {
        private static void Main()
        {
            string readline = Console.ReadLine();
            string[] number = readline.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            List<int> arryInts = new List<int>(number.Length);

            for (int i = 0; i < number.Length; i++)
            {
                arryInts.Add(int.Parse(number[i]));
            }

            for (int i = arryInts.Count - 1; i >= 1; i--)
            {
                for (int h = 0; h <= i - 1; h++)
                {
                    if (arryInts[h] > arryInts[h + 1])
                    {
                        var temp = arryInts[h + 1];
                        arryInts[h + 1] = arryInts[h];
                        arryInts[h] = temp;
                    }
                }
            }

            Console.WriteLine("{0}", string.Join(" ", arryInts));
        }
    }
}