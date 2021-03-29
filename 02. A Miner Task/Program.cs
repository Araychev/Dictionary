using System;
using System.Collections.Generic;

namespace _02._A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            string resourse = Console.ReadLine();

            var result = new Dictionary<string, int>();

            while (resourse != "stop")
            {
                int value = int.Parse(Console.ReadLine());

                if (result.ContainsKey(resourse))
                {
                    result[resourse] += value; 
                }
                else
                {
                    result.Add(resourse, value);
                }

                resourse = Console.ReadLine();

            }

            foreach (var item in result)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
