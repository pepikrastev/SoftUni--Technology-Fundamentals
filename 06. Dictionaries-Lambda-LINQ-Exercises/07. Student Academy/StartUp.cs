using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Student_Academy
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            Dictionary<string, List<double>> studentGrades = new Dictionary<string, List<double>>();

            for (int i = 0; i < number; i++)
            {
                string name = Console.ReadLine();
                double greade = double.Parse(Console.ReadLine());

                if (studentGrades.ContainsKey(name) == false)
                {
                    studentGrades[name] = new List<double>();
                }

                studentGrades[name].Add(greade);
            }

            Dictionary<string, List<double>> fillteredStudentGrades = studentGrades
                .Where(x => x.Value.Average() >= 4.50)
                .OrderByDescending(x => x.Value.Average())
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var kvp in fillteredStudentGrades)
            {
                string name = kvp.Key;
                List<double> grades = kvp.Value;

                Console.WriteLine($"{name} -> {grades.Average():f2}");
            }
        }
    }
}
