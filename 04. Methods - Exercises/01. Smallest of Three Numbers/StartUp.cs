namespace _01._Smallest_of_Three_Numbers
{
    using System;

    class StartUp
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());

            PrintSmallesNumber(firstNum, secondNum, thirdNum);

        }

        static void PrintSmallesNumber(int first, int second, int third)
        {
            int smalles = 0;

            if (first <= second && first <= third)
            {
                smalles = first;
            }
            else if (second < first && second < third)
            {
                smalles = second;
            }
            else if (third < first && third < second)
            {
                smalles = third;
            }

            Console.WriteLine(smalles);
        }
    }
}
