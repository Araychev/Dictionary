using System;
using System.Collections.Generic;

namespace _02._Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sequenceOfWord = Console.ReadLine().Split();

            var counts = new Dictionary<string, int>();

            foreach (var item in sequenceOfWord)
            {
                string wordInLowerCase = item.ToLower();

                if (counts.ContainsKey(wordInLowerCase))
                {
                    counts[wordInLowerCase]++;
                }
                else
                {
                    counts.Add(wordInLowerCase, 1);
                }
            }
            foreach (var kvp in counts)
            {
                if (kvp.Value % 2 != 0)
                {
                    Console.Write(kvp.Key + " ");
                }
            }
        }
    }
}
