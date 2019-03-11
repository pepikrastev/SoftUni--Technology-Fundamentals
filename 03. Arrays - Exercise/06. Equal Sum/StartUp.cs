namespace _06._Equal_Sum
{
    using System;
    using System.Linq;

    class StartUp
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int leftSum = 0;
            int rightsum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                rightsum += numbers[i];
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                rightsum -= numbers[i];

                if (rightsum == leftSum)
                {
                    Console.WriteLine(i);
                    return;
                }

                leftSum += numbers[i];
            }

            Console.WriteLine("no");
        }
    }
}
