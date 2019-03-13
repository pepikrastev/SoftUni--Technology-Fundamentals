using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._ForceBook
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Lumpawaroo")
                {
                    break;
                }

                string[] inputArgs = new string[0];

                if (input.Contains("|"))
                {
                    inputArgs = input.Split(" | ");
                    string side = inputArgs[0];
                    string name = inputArgs[1];

                    if (dictionary.ContainsKey(name) == false)
                    {
                        dictionary[name] = side;
                    }
                }
                else
                {
                    inputArgs = input.Split(" -> ");
                    string side = inputArgs[1];
                    string name = inputArgs[0];

                    if (dictionary.ContainsKey(name))
                    {
                        dictionary[name] = side;
                    }
                    else
                    {
                        dictionary[name] = side;
                    }

                    Console.WriteLine($"{name} joins the {side} side!");
                }
            }

            var fillteredDictionary = dictionary
                .GroupBy(x => x.Value)
                .ToDictionary(x => x.Key, x => x.ToDictionary(y => y.Key, y => y.Value))
                .OrderByDescending(x => x.Value.Count)
                .ThenBy(x => x.Key);

            foreach (var kvp in fillteredDictionary)
            {
                string side = kvp.Key;
                Dictionary<string, string> nameSideValue = kvp.Value;

                Console.WriteLine($"Side: {side}, Members: {nameSideValue.Count}");

                foreach (var kvpValue in nameSideValue.OrderBy(x => x.Key))
                {
                    string name = kvpValue.Key;
                    string side2 = kvpValue.Value;

                    Console.WriteLine($"! {name}");
                }
            }
        }
    }
}
