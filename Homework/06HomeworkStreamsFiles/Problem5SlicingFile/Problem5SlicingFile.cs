namespace Problem5SlicingFile
{
    using System;
    using System.IO;

    internal class Problem5SlicingFile
    {
        public static void SplitFile(string inputFile, string path, int chunkSize)
        {
            byte[] buffer = new byte[chunkSize];

            using (Stream input = File.OpenRead(inputFile))
            {
                int index = 0;
                while (input.Position < input.Length)
                {
                    using (Stream output = File.Create(path + "\\" + index))
                    {
                        int chunkBytesRead = 0;
                        while (chunkBytesRead < chunkSize)
                        {
                            int bytesRead = input.Read(buffer,
                                                       chunkBytesRead,
                                                       chunkSize - chunkBytesRead);

                            if (bytesRead == 0)
                            {
                                break;
                            }
                            chunkBytesRead += bytesRead;
                        }
                        output.Write(buffer, 0, chunkBytesRead);
                    }
                    index++;
                }
            }
        }
        private static void Main()
        {
            Console.WriteLine("Enter the file path:");
            string input = Console.ReadLine();
            Console.WriteLine("Enter the path after split:");
            string path = Console.ReadLine();
            Console.WriteLine("Enter size for splitting in bytes:");
            string nSize = Console.ReadLine();

            SplitFile(input, path, int.Parse(nSize));
        }
    }
}