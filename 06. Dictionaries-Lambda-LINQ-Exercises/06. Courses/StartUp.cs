using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Courses
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }

                string[] inputArgs = input.Split(" : ").ToArray();

                string course = inputArgs[0];
                string name = inputArgs[1];

                if (courses.ContainsKey(course) == false)
                {
                    courses[course] = new List<string>();
                }

                courses[course].Add(name);
            }

            foreach (var kvp in courses.OrderByDescending(x => x.Value.Count))
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value.Count}");

                kvp.Value.Sort();

                foreach (var item in kvp.Value)
                {
                    Console.WriteLine($"-- {item}");
                }
            }
        }
    }
}
