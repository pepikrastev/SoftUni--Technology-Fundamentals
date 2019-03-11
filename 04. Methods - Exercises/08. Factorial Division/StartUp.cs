namespace _08._Factorial_Division
{
    using System;

    class StartUp
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());

            long firstFactorial = Factorial(first);
            long secondFactorial = Factorial(second);

            Console.WriteLine($"{(double)firstFactorial / secondFactorial:f2}");
        }

        private static long Factorial(int first)
        {
            long factoral = 1;

            for (int i = 2; i <= first; i++)
            {
                factoral *= i;
            }
            return factoral;
        }
    }
}
