namespace Problem1OddLines
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    internal class Problem1OddLines
    {
        private static void Main()
        {
            List<string> names = new List<string>();

            using (
                StreamReader reader =
                    new StreamReader(
                        @"C:\Users\Iliqn\Desktop\C#\06HomeworkStreamsFiles\Problem1OddLines\MyTextFile.txt"))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();

                    names.Add(line);
                }
            }
            for (int i = 0; i < names.Count; i+=2)
            {
                Console.WriteLine(names[i]);
            }
        }
    }
}