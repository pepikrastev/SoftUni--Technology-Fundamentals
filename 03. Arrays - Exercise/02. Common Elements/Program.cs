﻿namespace _02._Common_Elements
{
    using System;
    using System.Linq;

    class StartUp
    {
        static void Main()
        {
            string[] arr1 = Console.ReadLine().Split().ToArray();
            string[] arr2 = Console.ReadLine().Split().ToArray();

            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = 0; j < arr2.Length; j++)
                {
                    if (arr1[i] == arr2[j])
                    {
                        Console.Write($"{arr1[i]} ");
                    }
                }
            }
            Console.WriteLine();
        }
    }
}