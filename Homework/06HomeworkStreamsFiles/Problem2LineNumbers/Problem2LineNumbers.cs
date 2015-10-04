namespace Problem2LineNumbers
{
    using System.IO;

    internal class Problem2LineNumbers
    {
        private static void Main()
        {
            int count = 1;

            using (
                StreamReader reader =
                    new StreamReader(
                        @"C:\Users\Iliqn\Desktop\C#\06HomeworkStreamsFiles\Problem1OddLines\MyTextFile.txt"))
            {
                using (
                    StreamWriter writer =
                        new StreamWriter(
                            @"C:\Users\Iliqn\Desktop\C#\06HomeworkStreamsFiles\Problem1OddLines\Important.txt"))
                {
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        writer.WriteLine("{0}. {1}", count, line);
                        count++;
                    }
                }
            }
        }
    }
}