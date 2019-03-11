namespace _07._NxN_Matrix
{
    using System;

    class StartUp
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            PrintNxnMatrix(num);
        }

        private static void PrintNxnMatrix(int num)
        {
            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j < num; j++)
                {
                    Console.Write(num + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
