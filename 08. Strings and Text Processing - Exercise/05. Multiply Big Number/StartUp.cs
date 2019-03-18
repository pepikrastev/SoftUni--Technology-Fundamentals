﻿using System;
using System.Linq;

class StartUp
{
    static void Main(string[] args)
    {
        string firstNimber = Console.ReadLine().TrimStart('0');
        int secondNumber = int.Parse(Console.ReadLine());

        int onMind = 0;

        string resultNumber = string.Empty;

        string reversedFirstNumber = string.Join("", firstNimber.ToCharArray().Reverse());

        if (firstNimber == "0" || secondNumber == 0)
        {
            Console.WriteLine(0);
            return;
        }

        for (int i = 0; i < reversedFirstNumber.Length; i++)
        {
            int firstDigit = int.Parse(reversedFirstNumber[i].ToString());

            int result = firstDigit * secondNumber + onMind;

            resultNumber += result % 10;

            onMind = result / 10;

            if (i == reversedFirstNumber.Length - 1 && onMind != 0)
            {
                resultNumber += onMind;
            }

        }

        string finalResult = string.Join("", resultNumber.ToCharArray().Reverse());

        Console.WriteLine(finalResult);
    }
}