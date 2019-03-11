namespace _05._Add_and_Subtract
{
    using System;

    class StartUp
    {
        static void Main(string[] args)
        {
            int numOne = int.Parse(Console.ReadLine());
            int numTwo = int.Parse(Console.ReadLine());
            int numThree = int.Parse(Console.ReadLine());

            GetSubtract(numOne, numTwo, numThree);
        }

        private static void GetSubtract(int numOne, int numTwo, int numThree)
        {
            int subtract = 0;
            subtract = GetSum(numOne, numTwo) - numThree;

            Console.WriteLine(subtract);
        }

        private static int GetSum(int numOne, int numTwo)
        {
            int sum = 0;
            sum = numOne + numTwo;
            return sum;
        }
    }
}
