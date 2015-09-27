namespace Problem3LargerThanNeighbours
{
    using System;

    internal class Problem3LargerThanNeighbours
    {
        private static void IsLargerThanNeighbours(int[] masiv, int check)
        {
            for (int i = 1; i < 2; i++)
            {
                if ((masiv[0] < check) & (check > masiv[2]))
                {
                    Console.WriteLine("True");
                }
                else
                {
                    Console.WriteLine("False");
                }
            }
        }

        private static void Main()
        {
            int[] numbers = { 1, 3, 4, 5, 1, 0, 5 };
            for (int i = 0; i < numbers.Length; i++)
            {
                IsLargerThanNeighbours(numbers, numbers[i]);
            }
        }
    }
}