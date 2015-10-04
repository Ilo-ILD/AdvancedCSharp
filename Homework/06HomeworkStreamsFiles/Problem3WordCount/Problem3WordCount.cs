namespace Problem3WordCount
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    internal class Problem3WordCount
    {
        private static void Main()
        {
            int count = 0;
            List<string> wordsReader = new List<string>();
            Dictionary<string, int> dictionary = new Dictionary<string, int>();

            using (
                StreamReader readerWords =
                    new StreamReader(@"C:\Users\Iliqn\Desktop\C#\06HomeworkStreamsFiles\Problem1OddLines\words.txt"))
            {
                while (!readerWords.EndOfStream)
                {
                    wordsReader.Add(readerWords.ReadLine());
                }
            }

            using (
                StreamReader reader =
                    new StreamReader(@"C:\Users\Iliqn\Desktop\C#\06HomeworkStreamsFiles\Problem1OddLines\text.txt"))
            {
                while (!reader.EndOfStream)
                {
                    // otvarqme text.txt i chete cql red!!!
                    string[] words =
                        reader.ReadLine()
                            .Split(new[] { ' ', '-', ',', '.', '?', '!', '`' }, StringSplitOptions.RemoveEmptyEntries)
                            .ToArray(); // reda go splitvam na duma po duma

                    for (int j = 0; j < wordsReader.Count; j++)
                    {
                        for (int i = 0; i < words.Length; i++)
                        {
                            if (words[i].ToLower() == wordsReader[j])
                            {
                                count++;
                            }
                        }

                        if (count != 0)
                        {
                            if (!dictionary.ContainsKey(wordsReader[j]))
                            {
                                dictionary.Add(wordsReader[j], count);
                            }
                            else
                            {
                                count = dictionary[wordsReader[j]] + count;
                                dictionary.Remove(wordsReader[j]);
                                dictionary.Add(wordsReader[j], count);
                            }
                        }

                        count = 0;
                    }
                }
            }

            using (
                StreamWriter writer =
                    new StreamWriter(@"C:\Users\Iliqn\Desktop\C#\06HomeworkStreamsFiles\Problem1OddLines\result.txt"))
            {
                foreach (KeyValuePair<string, int> kv in dictionary)
                {
                    writer.WriteLine("{0} - {1}", kv.Key, kv.Value);
                }
            }
        }
    }
}