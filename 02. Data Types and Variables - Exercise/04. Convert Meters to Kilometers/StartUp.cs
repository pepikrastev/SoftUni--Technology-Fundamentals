﻿namespace _04._Convert_Meters_to_Kilometers
{
    using System;

    class StartUp
    {
        static void Main(string[] args)
        {
            double meters = double.Parse(Console.ReadLine());
            double kilometers = meters / 1000;
            Console.WriteLine($"{kilometers:F2}");
        }
    }
}
