using System;

class StartUp
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split();

        string firstString = input[0];
        string secondString = input[1];

        long sum = CalculateSum(firstString, secondString);

        Console.WriteLine(sum);
    }

    private static long CalculateSum(string firstString, string secondString)
    {

        char[] firstArr = firstString.ToCharArray();
        char[] secondArr = secondString.ToCharArray();

        long sum = 0;

        int minLength = Math.Min(firstArr.Length, secondArr.Length);
        int maxLength = Math.Max(firstArr.Length, secondArr.Length);

        for (int i = 0; i < minLength; i++)
        {
            sum += firstArr[i] * secondArr[i];
        }

        if (maxLength == firstArr.Length)
        {
            for (int i = minLength; i < maxLength; i++)
            {
                sum += firstArr[i];
            }
        }
        else
        {
            for (int i = minLength; i < maxLength; i++)
            {
                sum += secondArr[i];
            }
        }

        return sum;
    }
}