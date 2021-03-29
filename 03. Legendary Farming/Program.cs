using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {
            var legendaryItems = new Dictionary<string, int>();
            {
                legendaryItems["shards"] = 0;
                legendaryItems["fragments"] = 0;
                legendaryItems["motes"] = 0;
            }

            var keyMaterials = new Dictionary<string, int>();

            bool isRunning = true;
            string winnerItem = string.Empty;

            while (isRunning)
            {
                string[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < input.Length; i+=2)
                {
                    int quaontity = int.Parse(input[i]);
                    string item = input[i + 1].ToLower();

                    if (legendaryItems.ContainsKey(item))
                    {
                        legendaryItems[item] += quaontity;
                        if (legendaryItems[item] >= 250)
                        {
                            winnerItem = item;
                            legendaryItems[item] -= 250;
                            isRunning = false;
                            break;
                        }
                    }
                    else
                    {
                        if (keyMaterials.ContainsKey(item))
                        {
                            keyMaterials[item] += quaontity;
                        }
                        else
                        {
                            keyMaterials.Add(item, quaontity);
                        }
                    }

                    
                }
            }

            if (winnerItem == "shards")
            {
                Console.WriteLine("Shadowmourne obtained!");
            }
            else if (winnerItem == "fragments")
            {
                Console.WriteLine("Valanyr obtained!");
            }
            else
            {
                Console.WriteLine("Dragonwrath obtained!");
            }

            var sortedLegendaryItems = legendaryItems
                .OrderByDescending(i => i.Value)
                .ThenBy(i => i.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var kvp in sortedLegendaryItems)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }

            var sortedKeyMaterials = keyMaterials
                .OrderBy(i => i.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var kvp in sortedKeyMaterials)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }

        }
    }
}
