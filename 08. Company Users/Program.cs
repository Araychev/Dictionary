using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Company_Users
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var employessByCompany = new SortedDictionary<string, List<string>>();

            while (input != "End" )
            {
                string[] token = input.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                string companyName = token[0];

                if (companyName == "End")
                {
                    input = "End";
                }

                if (!employessByCompany.ContainsKey(companyName))
                {
                    employessByCompany.Add(companyName, new List<string>());
                }
                if (!employessByCompany[companyName].Contains(token[1]))
                {
                    string emplyerId = token[1];
                    employessByCompany[companyName].Add(emplyerId);
                }

                input = Console.ReadLine();
            }

            foreach (var item in employessByCompany)
            {
                Console.WriteLine(item.Key);

                foreach (var kvp in item.Value)
                {
                    Console.WriteLine($"-- {kvp}");
                }
            }
        }
    }
}
