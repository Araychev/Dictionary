using System;
using System.Collections.Generic;

namespace _04._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            var orderPrice = new Dictionary<string, decimal>();
            var orderQuantity = new Dictionary<string, int>();

            while (command != "buy")
            {
                string[] newOrder = command.Split();
                string product = newOrder[0];
                decimal price = decimal.Parse(newOrder[1]);
                int quantity = int.Parse(newOrder[2]);

                if (orderPrice.ContainsKey(product))
                {
                    orderPrice[product] = price;
                    orderQuantity[product] += quantity;

                }
                else
                {
                    orderPrice.Add(product, price);
                    orderQuantity.Add(product, quantity);

                }

                command = Console.ReadLine();
            }

            foreach (var item in orderPrice)
            {
                string productName = item.Key;
                decimal price = item.Value;
                int qty = orderQuantity[productName];

                decimal totalPrice = price * qty;

                Console.WriteLine($"{productName} -> {totalPrice:f2}");
            }
        }
    }
}
