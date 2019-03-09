namespace _06._Strong_number
{
    using System;

    class StartUp
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int saveNumber = number;

            int result = 0;

            while (number != 0)
            {
                int factoriel = 1;

                int currentNumber = number % 10;

                number = number / 10;

                for (int i = 1; i < currentNumber; i++)
                {
                    factoriel += i * factoriel;
                }

                result += factoriel;
            }

            if (result == saveNumber)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }

        }
    }
}
