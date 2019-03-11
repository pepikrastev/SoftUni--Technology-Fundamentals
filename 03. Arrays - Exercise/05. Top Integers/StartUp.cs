namespace _05._Top_Integers
{
    using System;
    using System.Linq;

    class StartUp
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                int number = numbers[i];

                for (int j = i + 1; j < numbers.Length; j++)
                {
                    int secundNumber = numbers[j];

                    if (number <= secundNumber)
                    {
                        break;
                    }
                    else if (j == numbers.Length - 1)
                    {
                        Console.Write(number + " ");
                    }
                }
            }
            Console.WriteLine(numbers[numbers.Length - 1]);
        }
    }
}
