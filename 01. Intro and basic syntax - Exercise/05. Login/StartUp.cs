namespace _05._Login
{
    using System;

    class StartUp
    {
        static void Main(string[] args)
        {
            string password = string.Empty;
            string username = Console.ReadLine();

            for (int i = username.Length - 1; i >= 0; i--)
            {
                password += username[i];

            }

            int counter = 0;

            while (true)
            {
                string login = Console.ReadLine();

                if (login == password)
                {
                    Console.WriteLine($"User {username} logged in.");
                    counter += 1;
                    return;

                }
                else
                {
                    Console.WriteLine($"Incorrect password. Try again.");
                    counter += 1;
                }

                if (counter == 3)
                {
                    Console.WriteLine($"User {username} blocked!");
                    return;
                }
            }
        }
    }
}
