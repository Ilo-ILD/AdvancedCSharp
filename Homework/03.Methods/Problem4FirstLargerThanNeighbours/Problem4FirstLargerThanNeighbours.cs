namespace Problem3LargerThanNeighbours
{
    using System;

    internal class Problem3LargerThanNeighbours
    {
        private static void IsLargerThanNeighbours(int[] masiv)
        {
            int bigger = 0;
            for (int i = 1; i < masiv.Length - 1; i++)
            {
                if ((masiv[i - 1] < masiv[i]) & (masiv[i] > masiv[i + 1]))
                {
                    bigger = masiv[i];
                    Console.WriteLine(bigger);
                    return;
                }
            }

            if (bigger == 0)
            {
                Console.WriteLine("-1");
            }
        }

        private static void Main()
        {
            int[] numbersOne = { 1, 3, 4, 5, 1, 0, 5 };
            int[] numbersTwo = { 1, 2, 3, 4, 5, 6, 6 };
            int[] numbersThree = { 1, 1, 1 };

            IsLargerThanNeighbours(numbersOne);
            IsLargerThanNeighbours(numbersTwo);
            IsLargerThanNeighbours(numbersThree);
        }
    }
}