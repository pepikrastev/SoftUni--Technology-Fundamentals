namespace _03._House_Party
{
    using System;
    using System.Collections.Generic;

    class StartUp
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            List<string> partyList = new List<string>();

            for (int i = 0; i < number; i++)
            {
                string partyPeople = Console.ReadLine();

                string[] tokens = partyPeople.Split();

                if (tokens[2] == "going!")
                {
                    if (partyList.Contains(tokens[0]) == false)
                    {
                        partyList.Add(tokens[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{tokens[0]} is already in the list!");
                    }
                }
                else if (tokens[2] == "not")
                {
                    if (partyList.Contains(tokens[0]) == false)
                    {
                        Console.WriteLine($"{tokens[0]} is not in the list!");
                    }
                    else
                    {
                        partyList.Remove(tokens[0]);
                    }

                }

            }

            foreach (var item in partyList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
