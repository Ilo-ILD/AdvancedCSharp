namespace AdvanceCHomework
{
    using System;
    using System.Collections.Generic;

    internal class SortArray
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

            arryInts.Sort();
            Console.WriteLine("{0}", string.Join(" ", arryInts));
        }
    }
}