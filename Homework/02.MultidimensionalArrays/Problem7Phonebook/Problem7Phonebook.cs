namespace Problem7Phonebook
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class Problem7Phonebook
    {
        private static void Main()
        {
            Dictionary<string, string> Phonebook = new Dictionary<string, string>();
            while (true)
            {
                string[] readLineComand = Console.ReadLine().Split('-').ToArray();

                if (readLineComand[0] == "END")
                {
                    return;
                }
                if (readLineComand[0] == "search")
                {
                    string[] name = Console.ReadLine().Split();
                    if (Phonebook.ContainsKey(name[0]))
                    {
                        foreach (KeyValuePair<string, string> p in Phonebook)
                        {
                            Console.WriteLine("{0} -> {1}", p.Key, p.Value);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Contact {0} does not exist.", name[0]);
                    }
                }
                else
                {
                    if (Phonebook.Count != 0)
                    {
                        if (readLineComand.Length == 1)
                        {
                            Console.WriteLine("{0} -> {1}", readLineComand[0], Phonebook[readLineComand[0]]);
                        }
                    }
                    else
                    {
                        Phonebook.Add(readLineComand[0], readLineComand[1]);
                    }
                }
            }
        }
    }
}