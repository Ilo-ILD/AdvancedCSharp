namespace Problem1BiggerNumber
{
    using System;

    internal class Problem1BiggerNumber
    {
        private static void GetMax(int firstNumber, int secondNumber)
        {
            if (firstNumber > secondNumber)
            {
                Console.WriteLine(firstNumber);
            }
            else
            {
                Console.WriteLine(secondNumber);
            }
        }

        private static void Main()
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            GetMax(firstNumber, secondNumber);
        }
    }
}