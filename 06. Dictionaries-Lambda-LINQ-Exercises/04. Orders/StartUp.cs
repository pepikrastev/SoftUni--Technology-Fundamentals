using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Orders
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> products = new Dictionary<string, int>();

            Dictionary<string, double> prices = new Dictionary<string, double>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "buy")
                {
                    break;
                }

                string[] list = input.Split().ToArray();

                string currentProduct = list[0];
                double price = double.Parse(list[1]);
                int quantity = int.Parse(list[2]);

                if (!products.ContainsKey(currentProduct))
                {
                    products[currentProduct] = 0;
                    prices[currentProduct] = 0;
                }

                products[currentProduct] += quantity;
                prices[currentProduct] = price;


            }

            foreach (var kvp in prices)
            {
                string product = kvp.Key;
                int quantity = products[product];
                double price = kvp.Value;

                double result = quantity * price;

                Console.WriteLine($"{product} -> {result:f2}");
            }
        }
    }
}
