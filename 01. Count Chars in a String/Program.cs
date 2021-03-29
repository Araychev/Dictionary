using System;
using System.Collections.Generic;

namespace _01._Count_Chars_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            var counts = new Dictionary<char, int>();

            foreach (char letter in word)
            {
                if (letter == ' ')
                {
                    continue;
                }
                if (counts.ContainsKey(letter))
                {
                    counts[letter]++;
                }
                else
                {
                    counts.Add(letter, 1);
                }
            }
            foreach (var item in counts)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }

        }
    }
}
