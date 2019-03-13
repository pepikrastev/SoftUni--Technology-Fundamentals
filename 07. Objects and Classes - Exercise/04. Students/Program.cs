using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Students
{
    class Program
    {
        static void Main(string[] args)
        {
            int countStudents = int.Parse(Console.ReadLine());

            List<Students> students = new List<Students>();

            for (int i = 0; i < countStudents; i++)
            {
                string[] input = Console.ReadLine().Split();

                string firsName = input[0];
                string lastName = input[1];
                double grade = double.Parse(input[2]);

                Students student = new Students()
                {
                    FirstName = firsName,
                    LastName = lastName,
                    Grade = grade

                };

                students.Add(student);
            }

            students = students.OrderByDescending(x => x.Grade).ToList();

            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }
    }


    class Students
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}: {Grade:f2}";
        }
    }
}
