namespace Problem4CopyBinaryFile
{
    using System;
    using System.IO;

    internal class Problem4CopyBinaryFile
    {
        private static void Main()
        {
            string filename;
            Console.WriteLine("enter file location");
            filename = Console.ReadLine();
            FileStream fs = new FileStream(filename, FileMode.Open);
            BinaryReader br = new BinaryReader(fs);
            string str;
            str = Convert.ToString(br.Read());
            while (str != null)
            {
                Console.WriteLine(str);
                str = Convert.ToString(br.Read());
            }

            fs.Close();
            br.Close();
        }
    }
}