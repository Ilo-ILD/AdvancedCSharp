namespace CategorizeNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    internal class Program
    {
        private static void Main()
        {
            string readLine = Console.ReadLine();
            string[] numbers = readLine.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Regex regexFloats = new Regex(@"-?[0-9]*\.[0-9]*");
            List<int> integers = new List<int>(numbers.Length);
            List<float> floats = new List<float>(numbers.Length);

            for (int i = 0; i < numbers.Length; i++)
            {
                if (regexFloats.IsMatch(numbers[i]))
                {
                    floats.Add(float.Parse(numbers[i]));
                }
                else
                {
                    integers.Add(int.Parse(numbers[i]));
                }
            }

            Console.WriteLine(
                "{0} -> min: {1} max: {2} sum: {3} avg: {4}", 
                string.Join(" ", integers), 
                integers.Min(), 
                integers.Max(), 
                integers.Sum(), 
                integers.Average());
            Console.WriteLine();
            Console.WriteLine(
                "{0} -> min: {1} max: {2} sum: {3} avg: {4:f}", 
                string.Join(" ", floats), 
                floats.Min(), 
                floats.Max(), 
                floats.Sum(), 
                floats.Average());
        }
    }
}