namespace Problem5ReverseNumber
{
    using System;

    internal class Problem5ReverseNumber
    {
        private static void GetReversedNumber(double numb)
        {
            string number = numb.ToString();
            for (int i = number.Length - 1; i >= 0; i--)
            {
                Console.Write(number[i]);
            }

            Console.WriteLine();
        }

        private static void Main()
        {
            GetReversedNumber(256);
            GetReversedNumber(123.45);
            GetReversedNumber(0.12);
        }
    }
}