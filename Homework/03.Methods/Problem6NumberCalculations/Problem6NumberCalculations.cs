namespace Problem6NumberCalculations
{
    using System;

    internal class Problem6NumberCalculations
    {
        private static void ProductValueFromSet(double[] valueMasive)
        {
            Console.WriteLine(Math.Pow(2, valueMasive.Length));
        }

        private static void AverageValueFromSet(double[] valueMasive)
        {
            double summ = 0;
            for (int i = 0; i < valueMasive.Length; i++)
            {
                summ += valueMasive[i];
            }

            Console.WriteLine(summ / valueMasive.Length);
        }

        private static void SummValueFromSet(double[] valueMasive)
        {
            double summ = 0;
            for (int i = 0; i < valueMasive.Length; i++)
            {
                summ += valueMasive[i];
            }

            Console.WriteLine(summ);
        }

        private static void MaximumValueFromSet(double[] valueMasive)
        {
            double max = int.MinValue;
            for (int i = 0; i < valueMasive.Length; i++)
            {
                if (valueMasive[i] > max)
                {
                    max = valueMasive[i];
                }
            }

            Console.WriteLine(max);
        }

        private static void MinimumValueFromSet(double[] valueMasive)
        {
            double min = int.MaxValue;
            for (int i = 0; i < valueMasive.Length; i++)
            {
                if (valueMasive[i] < min)
                {
                    min = valueMasive[i];
                }
            }

            Console.WriteLine(min);
        }

        private static void Main()
        {
            double[] numbersMasiv = { 1, 2, 3 };

            MinimumValueFromSet(numbersMasiv);
            MaximumValueFromSet(numbersMasiv);
            SummValueFromSet(numbersMasiv);
            AverageValueFromSet(numbersMasiv);
            ProductValueFromSet(numbersMasiv);
        }
    }
}