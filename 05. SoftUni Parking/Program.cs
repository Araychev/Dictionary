using System;
using System.Collections.Generic;

namespace _05._SoftUni_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse
                (Console.ReadLine());

            var parkingLot = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string command = input[0];
                string user = input[1];
                
                if (command == "register")
                {
                    if (parkingLot.ContainsKey(user))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {input[2]}");
                    }
                    else
                    {
                        parkingLot.Add(user, input[2]);
                        Console.WriteLine($"{user} registered {input[2]} successfully");
                    }
                }
                else
                {
                    if (parkingLot.ContainsKey(user))
                    {
                        parkingLot.Remove(user);
                        Console.WriteLine($"{user} unregistered successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {user} not found");
                    }

                }
            }

            foreach (var item in parkingLot)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }
    }
}
