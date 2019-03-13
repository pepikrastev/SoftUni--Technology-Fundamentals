using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._SoftUni_Parking
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            Dictionary<string, string> parking = new Dictionary<string, string>();

            for (int i = 0; i < number; i++)
            {
                string[] input = Console.ReadLine().Split().ToArray();

                string commad = input[0];

                if (commad == "register")
                {
                    string userName = input[1];
                    string userNumber = input[2];

                    if (parking.ContainsKey(userName) == false)
                    {
                        parking[userName] = userNumber;
                        Console.WriteLine($"{userName} registered {userNumber} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {parking[userName]}");
                    }
                }
                else if (commad == "unregister")
                {
                    string userName = input[1];

                    if (parking.ContainsKey(userName) == false)
                    {
                        Console.WriteLine($"ERROR: user {userName} not found");
                    }
                    else
                    {
                        Console.WriteLine($"{userName} unregistered successfully");
                        parking.Remove(userName);
                    }
                }
            }

            foreach (var item in parking)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }
    }
}
