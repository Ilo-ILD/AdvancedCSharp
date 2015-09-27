namespace SequencesOfEqualStrings
{
    using System;
    using System.Collections.Generic;

    internal class SequencesOfEqualStrings
    {
        private static void Main()
        {
            string readLine = Console.ReadLine();
            string[] strings = readLine.Split(' ');
            List<int> numbers = new List<int>();
            var sequence = new List<int>();
            bool isEnqueued = false;
            for (int i = 0; i < strings.Length; i++)
            {
                numbers.Add(int.Parse(strings[i]));
            }

            List<List<int>> sequences = new List<List<int>>();

            for (int i = 1; i < numbers.Count; i++)
            {
                if (isEnqueued)
                {
                    sequence = new List<int>();

                    isEnqueued = false;
                }

                if (numbers[i - 1] < numbers[i])
                {
                    sequence.Add(numbers[i - 1]);

                    if (i == numbers.Count - 1)
                    {
                        sequence.Add(numbers[i]);
                        sequences.Add(sequence);
                    }
                }
                else if (numbers[i - 1] >= numbers[i])
                {
                    sequence.Add(numbers[i - 1]);
                    sequences.Add(sequence);
                    isEnqueued = true;

                    if (i == numbers.Count - 1)
                    {
                        sequence = new List<int>();
                        sequence.Add(numbers[i]);
                        sequences.Add(sequence);
                    }
                }
            }

            var longest = new List<int>();

            foreach (var element in sequences)
            {
                if (element.Count > longest.Count)
                {
                    longest = element;
                }

                Console.WriteLine(string.Join(" ", element));
            }

            Console.WriteLine("Longest: " + string.Join(" ", longest));
        }
    }
}
