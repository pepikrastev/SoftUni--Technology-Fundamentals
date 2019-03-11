namespace _04._List_Operations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "End")
                {
                    break;
                }

                string[] tokens = input.Split();

                string command = tokens[0];

                if (command == "Add") 
                {
                    int numberToAdd = int.Parse(tokens[1]);
                    numbers.Add(numberToAdd); 
                }
                else if (command == "Insert")
                {
                    int number = int.Parse(tokens[1]);
                    int index = int.Parse(tokens[2]);

                    if (index > numbers.Count || index < 0)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    numbers.Insert(index, number);
                }
                else if (command == "Remove")
                {
                    int index = int.Parse(tokens[1]);

                    if (index > numbers.Count || index < 0)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    numbers.RemoveAt(index);
                }
                else if (command == "Shift")
                {
                    string direction = tokens[1];
                    int rotations = int.Parse(tokens[2]);

                    if (direction == "left")
                    {

                        for (int i = 0; i < rotations; i++) 
                        {
                            int firstNumber = numbers[0];
                            numbers.Add(firstNumber);
                            numbers.RemoveAt(0);
                            
                        }
                    }
                    else
                    {

                        for (int i = 0; i < rotations; i++) 
                        {
                            int lastNumber = numbers.Last();
                            numbers.Insert(0, lastNumber);
                            numbers.RemoveAt(numbers.Count - 1);
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
