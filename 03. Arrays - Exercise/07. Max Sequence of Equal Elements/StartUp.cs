﻿namespace _07._Max_Sequence_of_Equal_Elements
{
    using System;
    using System.Linq;

    class StartUp
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int maxSum = 0;
            int maxValue = 0;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                int counter = 1;

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        counter++;
                    }
                    else
                    {
                        break;
                    }
                }
                if (maxSum < counter)
                {
                    maxSum = counter;
                    maxValue = arr[i];
                }
            }

            for (int i = 0; i < maxSum; i++)
            {
                Console.Write($"{maxValue} ");
            }

            Console.WriteLine();
        }
    }
}
