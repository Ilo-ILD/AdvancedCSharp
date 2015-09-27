namespace Problem8NightLife
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class Problem8NightLife
    {
        private static void Main()
        {
            Queue<string> grad = new Queue<string>();
            SortedDictionary<string, string> venueAndEvent = new SortedDictionary<string, string>();

            while (true)
            {
                string[] readLineComand = Console.ReadLine().Split(';').ToArray();
                if (readLineComand[0] == "END")
                {
                    for (int i = 0; i < grad.Count; i++)
                    {
                        Console.WriteLine(grad.Peek());
                        foreach (KeyValuePair<string, string> p in venueAndEvent)
                        {
                            Console.WriteLine("->{0}: {1}", p.Key, p.Value);
                        }
                    }
                    return;
                }

                if (venueAndEvent.ContainsKey(readLineComand[1]))
                {
                    string value = venueAndEvent[readLineComand[1]];
                    venueAndEvent.Remove(readLineComand[1]);
                    venueAndEvent.Add(readLineComand[1], value + value);
                }
                else if (true)
                {
                    grad.Enqueue(readLineComand[0]);
                    venueAndEvent.Add(readLineComand[1], readLineComand[2]);
                }
            }
        }
    }
}