using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Company_Users
{
    class StartUp
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, HashSet<string>> courses = new SortedDictionary<string, HashSet<string>>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }

                string[] inputArgs = input.Split(" -> ").ToArray();

                string cours = inputArgs[0];
                string name = inputArgs[1];

                if (courses.ContainsKey(cours) == false)
                {
                    courses[cours] = new HashSet<string>();
                }

                courses[cours].Add(name);
            }

            foreach (var kvp in courses)
            {
                Console.WriteLine($"{kvp.Key}");


                foreach (var item in kvp.Value)
                {

                    Console.WriteLine($"-- {item}");
                }

            }
        }
    }
}
