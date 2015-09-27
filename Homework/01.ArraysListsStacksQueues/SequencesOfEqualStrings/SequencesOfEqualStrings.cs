namespace SequencesOfEqualStrings
{
    using System;

    internal class SequencesOfEqualStrings
    {
        private static void Main()
        {
            string readLine = Console.ReadLine();
            string[] strings = readLine.Split(' ');

            for (int i = 1; i < strings.Length; i++)
            {
                if (strings[i - 1] == strings[i])
                {
                    Console.Write(strings[i - 1]);
                    Console.Write(" ");
                }
                else if (strings[i - 1] != strings[i])
                {
                    Console.WriteLine(strings[i - 1]);
                }
            }

            if (strings[strings.Length - 2] == strings[strings.Length - 1])
            {
                Console.Write(strings[strings.Length - 1]);
                Console.Write(" ");
            }
            else
            {
                Console.WriteLine(strings[strings.Length - 1]);
            }
            Console.WriteLine();
        }
    }
}