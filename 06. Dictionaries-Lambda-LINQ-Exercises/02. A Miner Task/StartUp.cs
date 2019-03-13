namespace _02._A_Miner_Task
{
    using System;
    using System.Collections.Generic;

    class StartUp
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> capacity = new Dictionary<string, int>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "stop")
                {
                    break;
                }

                int quantity = int.Parse(Console.ReadLine());

                if (!capacity.ContainsKey(input))
                {
                    capacity[input] = 0;
                }

                capacity[input] += quantity;
            }

            foreach (var kvp in capacity)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
