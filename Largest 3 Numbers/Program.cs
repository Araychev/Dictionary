using System;
using System.Linq;

namespace Largest_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbres = Console.ReadLine()
                  .Split()
                  .Select(int.Parse)
                  .OrderByDescending(n => n)
                  .ToArray();

            int count = numbres.Length >= 3 ? 3 : numbres.Length;

            for (int i = 0; i < count; i++)
            {
                Console.Write($"{numbres[i]} ");
            }
            Console.WriteLine();
        }
    }
}
